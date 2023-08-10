using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using Serilog;
using System.Data.SqlClient;

namespace LocadoraDeVeiculos.Aplicacao.ModuloCondutor {
    
    public class ServicoCondutor {
        IRepositorioCondutor repositorioCondutor;
        IValidadorCondutor validadorCondutor;

        public ServicoCondutor(IRepositorioCondutor repositorioCondutor, IValidadorCondutor validadorCondutor) {
            this.repositorioCondutor = repositorioCondutor;
            this.validadorCondutor = validadorCondutor;
        }

        public Result Inserir(Condutor condutor) {
            Log.Debug($"Tentando inserir condutor...{condutor}");

            List<string> erros = ValidarCondutor(condutor);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try {
                repositorioCondutor.Inserir(condutor);

                Log.Debug($"Condutor {condutor.Id} inserido com sucesso");

                return Result.Ok(); //cenário 1
            } 
            catch (Exception exc) {
                string msgErro = "Falha ao tentar inserir condutor.";

                Log.Error(exc, msgErro + $"{condutor}");

                return Result.Fail(msgErro); //cenário 3
            }
        }

        public Result Editar(Condutor condutor) {
            Log.Debug($"Tentando editar condutor...{condutor}");

            List<string> erros = ValidarCondutor(condutor);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try {
                repositorioCondutor.Editar(condutor);

                Log.Debug($"Condutor {condutor.Id} editado com sucesso");

                return Result.Ok();
            } catch (Exception ex) {
                string msgErro;

                //Conferir depois quais bancos utilizam condutor
                if (ex.Message.Contains("FK_TBAluguel_TBCondutor"))
                    msgErro = "Este condutor está relacionada com um aluguel em aberto e não pode ser editado";
                else
                    msgErro = "Falha ao tentar editar condutor";

                Log.Error(ex, msgErro + $"{condutor.Id}");

                return Result.Fail(msgErro);
            }
        }

        public Result Excluir(Condutor condutor) {
            Log.Debug($"Tentando excluir condutor...{condutor}");

            try {
                bool condutorExiste = repositorioCondutor.Existe(condutor);

                if (condutorExiste == false) {
                    Log.Warning($"Condutor {condutor.Id} não encontrado para excluir");

                    return Result.Fail("Condutor não encontrado");
                }

                repositorioCondutor.Excluir(condutor);

                Log.Debug($"Condutor {condutor.Id} excluído com sucesso");

                return Result.Ok();
            } catch (Exception ex) {
                List<string> erros = new List<string>();

                string msgErro;

                //Conferir depois quais bancos utilizam condutor
                if (ex.Message.Contains("FK_TBAluguel_TBCondutor"))
                    msgErro = "Este condutor está relacionada com um aluguel em aberto e não pode ser excluído";
                else
                    msgErro = "Falha ao tentar excluir condutor";

                erros.Add(msgErro);

                Log.Error(ex, msgErro + $" {condutor.Id}");
                return Result.Fail(erros);
            }
        }

        private List<string> ValidarCondutor(Condutor condutor) {
            var resultadoValidacao = validadorCondutor.Validate(condutor);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            if (NomeDuplicado(condutor))
                erros.Add($"Este nome '{condutor.Nome}' já está sendo utilizado");

            foreach (string erro in erros) {
                Log.Warning(erro);
            }
            return erros;
        }

        private bool NomeDuplicado(Condutor condutor) {
            Condutor condutorEncontrada = repositorioCondutor.SelecionarPorNome(condutor.Nome);

            if (condutorEncontrada != null &&
                condutorEncontrada.Id != condutor.Id &&
                condutorEncontrada.Nome == condutor.Nome) {
                return true;
            }

            return false;
        }

    }
}

