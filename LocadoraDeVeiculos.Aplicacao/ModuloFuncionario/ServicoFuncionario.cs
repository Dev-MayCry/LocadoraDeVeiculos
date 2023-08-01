using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Aplicacao.ModuloFuncionario {
    public class ServicoFuncionario {

        private IRepositorioFuncionario repositorioFuncionario;
        private IValidadorFuncionario validadorFuncionario;

        public ServicoFuncionario(IRepositorioFuncionario repositorioFuncionario, IValidadorFuncionario validadorFuncionario) {

            this.repositorioFuncionario = repositorioFuncionario;
            this.validadorFuncionario = validadorFuncionario;

        }

        public Result Inserir(Funcionario funcionario) {
            Log.Debug("Tentando inserir funcionário...{@d}", funcionario);

            List<string> erros = ValidarFuncionario(funcionario);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try {
                repositorioFuncionario.Inserir(funcionario);

                Log.Debug("Funcionário {FuncionarioId} inserido com sucesso", funcionario.Id);

                return Result.Ok(); //cenário 1
            } catch (Exception exc) {
                string msgErro = "Falha ao tentar inserir funcionário.";

                Log.Error(exc, msgErro + "{@d}", funcionario);

                return Result.Fail(msgErro); //cenário 3
            }
        }

        public Result Editar(Funcionario funcionario) {
            Log.Debug("Tentando editar funcionário...{@d}", funcionario);

            List<string> erros = ValidarFuncionario(funcionario);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try {
                repositorioFuncionario.Editar(funcionario);

                Log.Debug("Funcionário {FuncionarioId} editado com sucesso", funcionario.Id);

                return Result.Ok();
            } catch (Exception exc) {

                string msgErro = "Falha ao tentar editar funcionário.";

                Log.Error(exc, msgErro + "{@d}", funcionario);

                return Result.Fail(msgErro);
            }
        }

        public Result Excluir(Funcionario funcionario) {

            Log.Debug("Tentando excluir funcionário...{@d}", funcionario);

            try {
                bool funcionarioExiste = repositorioFuncionario.Existe(funcionario);

                if (funcionarioExiste == false) {
                    Log.Warning("Funcionário {FuncionarioId} não encontrado para excluir", funcionario.Id);

                    return Result.Fail("Funcionário não encontrada");
                }

                repositorioFuncionario.Excluir(funcionario);

                Log.Debug("Funcionário {FuncionarioId} excluído com sucesso", funcionario.Id);

                return Result.Ok();
            } catch (SqlException ex) {
                List<string> erros = new List<string>();

                string msgErro;
                
                msgErro = "Falha ao tentar excluir funcionario";

                erros.Add(msgErro);

                Log.Error(ex, msgErro + " {FuncionarioId}", funcionario.Id);

                return Result.Fail(erros);
            }
        }

        private List<string> ValidarFuncionario(Funcionario funcionario) {
            var resultadoValidacao = validadorFuncionario.Validate(funcionario);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            if (NomeDuplicado(funcionario))
                erros.Add($"Este nome '{funcionario.Nome}' já está sendo utilizado");

            foreach (string erro in erros) {
                Log.Warning(erro);
            }

            return erros;
        }

        private bool NomeDuplicado(Funcionario funcionario) {
            Funcionario funcionarioEncontrado = repositorioFuncionario.SelecionarPorNome(funcionario.Nome);

            if (funcionarioEncontrado != null &&
                funcionarioEncontrado.Id != funcionario.Id &&
                funcionarioEncontrado.Nome == funcionario.Nome && 
                funcionarioEncontrado.Salario == funcionarioEncontrado.Salario &&
                funcionarioEncontrado.DataAdmissao == funcionarioEncontrado.DataAdmissao) {
                return true;
            }

            return false;
        }
    }
}
