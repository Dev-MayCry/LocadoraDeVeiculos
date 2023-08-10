using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using Serilog;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace LocadoraDeVeiculos.Aplicacao.ModuloAluguel {
    public class ServicoAluguel {
        IRepositorioAluguel repositorioAluguel;
        IValidadorAluguel validadorAluguel;
        IGeradorArquivo geradorArquivoPdf;

        public ServicoAluguel(IRepositorioAluguel repositorioAluguel, IValidadorAluguel validadorAluguel, IGeradorArquivo geradorArquivo) {
            this.repositorioAluguel = repositorioAluguel;
            this.validadorAluguel = validadorAluguel;
            this.geradorArquivoPdf = geradorArquivo;
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

        public Result GerarAluguelEmPDF(Aluguel aluguel, bool encerrado) {
            Log.Debug("Tentando gerar PDF do aluguel...{AluguelId}", aluguel.Id);

            try {
                geradorArquivoPdf.GerarAluguel(aluguel, encerrado);

                Log.Debug("Aluguel {AluguelId} em PDF gerado com sucesso", aluguel.Id);


                return Result.Ok();
            } catch (Exception ex) {
                List<string> erros = new List<string>();

                string msgErro = "Falha ao tentar gerar PDF do aluguel selecionado.";

                Log.Logger.Error(ex, msgErro + " {AluguelId}", aluguel.Id);

                erros.Add(msgErro);

                return Result.Fail(erros);
            }
        }

        private List<string> ValidarAluguel(Aluguel aluguel) {
            var resultadoValidacao = validadorAluguel.Validate(aluguel);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            if (AutomovelDuplicado(aluguel))
                erros.Add($"Este automóvel '{aluguel.Automovel}' já está sendo utilizado");
            
            if (CNHVencida(aluguel))
                erros.Add($"Este condutor '{aluguel.Condutor}' está com a CNH vencida");

            foreach (string erro in erros) {
                Log.Warning(erro);
            }
            return erros;
        }
        
        private bool AutomovelDuplicado(Aluguel aluguel) {
            Aluguel aluguelEncontrada = repositorioAluguel.SelecionarPorAutomovel(aluguel.Automovel);

            if (aluguelEncontrada != null &&
                aluguelEncontrada.Id != aluguel.Id &&
                aluguelEncontrada.Automovel == aluguel.Automovel &&
                aluguelEncontrada.Encerrado == false
                ) {
                return true;
            }

            return false;
        }

        private bool CNHVencida(Aluguel aluguel) {
            if (aluguel.Condutor.DataValidade.CompareTo(aluguel.DataLocacao) < 0) {
                return true;
            }

            return false;
        }
    }
}
