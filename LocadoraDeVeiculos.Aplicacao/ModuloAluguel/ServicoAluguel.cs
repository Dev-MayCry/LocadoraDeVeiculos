using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using Serilog;
using System.Data.SqlClient;

namespace LocadoraDeVeiculos.Aplicacao.ModuloAluguel {
    public class ServicoAluguel {
        IRepositorioAluguel repositorioAluguel;
        IValidadorAluguel validadorAluguel;

        public ServicoAluguel(IRepositorioAluguel repositorioAluguel, IValidadorAluguel validadorAluguel) {
            this.repositorioAluguel = repositorioAluguel;
            this.validadorAluguel = validadorAluguel;
        }

        public Result Inserir(Aluguel aluguel) {
            Log.Debug($"Tentando inserir aluguel...{aluguel}");

            List<string> erros = ValidarAluguel(aluguel);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try {
                repositorioAluguel.Inserir(aluguel);

                Log.Debug($"Aluguel {aluguel.Id} inserido com sucesso");

                return Result.Ok(); //cenário 1
            } catch (Exception exc) {
                string msgErro = "Falha ao tentar inserir aluguel.";

                Log.Error(exc, msgErro + $"{aluguel}");

                return Result.Fail(msgErro); //cenário 3
            }
        }

        public Result Editar(Aluguel aluguel) {
            Log.Debug($"Tentando editar aluguel...{aluguel}");

            List<string> erros = ValidarAluguel(aluguel);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try {
                repositorioAluguel.Editar(aluguel);

                Log.Debug($"Aluguel {aluguel.Id} editado com sucesso");

                return Result.Ok();
            } catch (Exception ex) {
                string msgErro;

                if (aluguel.Encerrado == true)
                    msgErro = "Este aluguel está encerrado e não pode ser editado";
                else
                    msgErro = "Falha ao tentar editar aluguel";

                Log.Error(ex, msgErro + $"{aluguel.Id}");

                return Result.Fail(msgErro);
            }
        }

        public Result Excluir(Aluguel aluguel) {
            Log.Debug($"Tentando excluir aluguel...{aluguel}");

            try {
                bool aluguelExiste = repositorioAluguel.Existe(aluguel);

                if (aluguelExiste == false) {
                    Log.Warning($"Aluguel {aluguel.Id} não encontrado para excluir");

                    return Result.Fail("Aluguel não encontrado");
                }

                repositorioAluguel.Excluir(aluguel);

                Log.Debug($"Aluguel {aluguel.Id} excluído com sucesso");

                return Result.Ok();
            } catch (SqlException ex) {
                List<string> erros = new List<string>();

                string msgErro;

                if (aluguel.Encerrado == true)
                    msgErro = "Este aluguel está encerrado e não pode ser excluído";
                else
                    msgErro = "Falha ao tentar excluir aluguel";

                erros.Add(msgErro);

                Log.Error(ex, msgErro + $" {aluguel.Id}");
                return Result.Fail(erros);
            }
        }

        private List<string> ValidarAluguel(Aluguel aluguel) {
            var resultadoValidacao = validadorAluguel.Validate(aluguel);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            //if (NomeDuplicado(aluguel))
              //  erros.Add($"Este nome '{aluguel.Automovel}' já está sendo utilizado");

            foreach (string erro in erros) {
                Log.Warning(erro);
            }
            return erros;
        }
        /*
        private bool NomeDuplicado(Aluguel aluguel) {
            Aluguel aluguelEncontrada = repositorioAluguel.SelecionarPorNome(aluguel.Nome);

            if (aluguelEncontrada != null &&
                aluguelEncontrada.Id != aluguel.Id &&
                aluguelEncontrada.Nome == aluguel.Nome) {
                return true;
            }

            return false;
        }*/
    }
}
