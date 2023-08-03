using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using Serilog;
using System.Data.SqlClient;

namespace LocadoraDeVeiculos.Aplicacao.ModuloAutomovel {
    public class ServicoAutomovel {
        private IRepositorioAutomovel repositorioAutomovel;
        private IValidadorAutomovel validadorAutomovel;

        public ServicoAutomovel(IRepositorioAutomovel repositorioAutomovel, IValidadorAutomovel validadorAutomovel) {

            this.repositorioAutomovel = repositorioAutomovel;
            this.validadorAutomovel = validadorAutomovel;
        }

        public Result Inserir(Automovel automovel) {
            Log.Debug($"Tentando inserir automóvel...{automovel}");

            List<string> erros = ValidarAutomovel(automovel);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try {
                repositorioAutomovel.Inserir(automovel);

                Log.Debug($"Automóvel {automovel.Id} inserido com sucesso");

                return Result.Ok(); //cenário 1
            } catch (Exception exc) {
                string msgErro = "Falha ao tentar inserir automóvel.";

                Log.Error(exc, msgErro + $"{automovel}");

                return Result.Fail(msgErro); //cenário 3
            }
        }

        public Result Editar(Automovel automovel) {
            Log.Debug($"Tentando editar automóvel...{automovel}");

            List<string> erros = ValidarAutomovel(automovel);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try {
                repositorioAutomovel.Editar(automovel);

                Log.Debug($"Automóvel {automovel.Id} editado com sucesso");

                return Result.Ok();
            } catch (Exception exc) {
                string msgErro = "Falha ao tentar editar automóvel.";

                Log.Error(exc, msgErro + $"{automovel.Id}");

                return Result.Fail(msgErro);
            }
        }

        public Result Excluir(Automovel automovel) {
            Log.Debug($"Tentando excluir automóvel...{automovel}");

            try {
                bool automovelExiste = repositorioAutomovel.Existe(automovel);

                if (automovelExiste == false) {
                    Log.Warning($"Automóvel {automovel.Id} não encontrado para excluir");

                    return Result.Fail("Automóvel não encontrado");
                }

                repositorioAutomovel.Excluir(automovel);

                Log.Debug($"Automóvel {automovel.Id} excluído com sucesso");

                return Result.Ok();
            } catch (SqlException ex) {
                List<string> erros = new List<string>();

                string msgErro;

                //não pode excluir caso esteja sendo utilizado em alugueis abertos
                if (ex.Message.Contains("FK_TBAluguel_TBAutomovel"))
                    msgErro = "Este automóvel está relacionada com um aluguel aberto e não pode ser excluído";
                else
                    msgErro = "Falha ao tentar excluir automóvel";

                erros.Add(msgErro);

                Log.Error(ex, msgErro + $" {automovel.Id}");

                return Result.Fail(erros);
            }
        }

        private List<string> ValidarAutomovel(Automovel automovel) {
            var resultadoValidacao = validadorAutomovel.Validate(automovel);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            if (PlacaDuplicada(automovel))
                erros.Add($"Esta placa '{automovel.Placa}' já está sendo utilizada");

            foreach (string erro in erros) {
                Log.Warning(erro);
            }

            return erros;
        }

        private bool PlacaDuplicada(Automovel automovel) {
            Automovel automovelEncontrado = repositorioAutomovel.SelecionarPorPlaca(automovel.Placa);

            if (automovelEncontrado != null &&
                automovelEncontrado.Id != automovel.Id &&
                automovelEncontrado.Placa == automovel.Placa) {
                return true;
            }

            return false;
        }
    }
}
