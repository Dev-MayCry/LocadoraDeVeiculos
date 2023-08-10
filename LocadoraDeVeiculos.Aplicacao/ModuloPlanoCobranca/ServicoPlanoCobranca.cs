using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using Serilog;
using System.Data.SqlClient;

namespace LocadoraDeVeiculos.Aplicacao.ModuloPlanoCobranca {
    public class ServicoPlanoCobranca {

        private IRepositorioPlanoCobranca repositorioPlanoCobranca;
        private IValidadorPlanoCobranca validadorPlanoCobranca;

        public ServicoPlanoCobranca(IRepositorioPlanoCobranca repositorioPlanoCobranca, IValidadorPlanoCobranca validadorPlanoCobranca) {

            this.repositorioPlanoCobranca = repositorioPlanoCobranca;
            this.validadorPlanoCobranca = validadorPlanoCobranca;

        }

        public Result Inserir(PlanoCobranca planoCobranca) {
            Log.Debug("Tentando inserir plano de Cobrança...{@d}", planoCobranca);

            List<string> erros = ValidarPlanoCobranca(planoCobranca);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try {
                if (!planoCobranca.grupo.IncluirPlano(planoCobranca)) {
                    return Result.Fail("O grupo selecionado já possui esse modelo de cobrança!");
                }
                repositorioPlanoCobranca.Inserir(planoCobranca);

                Log.Debug("Plano de Cobrança {PlanoCobrancaId} inserido com sucesso", planoCobranca.Id);

                return Result.Ok(); //cenário 1
            } catch (Exception exc) {
                string msgErro = "Falha ao tentar inserir plano de Cobrança.";

                Log.Error(exc, msgErro + "{@d}", planoCobranca);

                return Result.Fail(msgErro); //cenário 3
            }
        }

        public Result Editar(PlanoCobranca planoCobranca) {
            Log.Debug("Tentando editar plano de Cobrança...{@d}", planoCobranca);

            List<string> erros = ValidarPlanoCobranca(planoCobranca);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try {
                repositorioPlanoCobranca.Editar(planoCobranca);

                Log.Debug("Plano de Cobrança {PlanoCobrancaId} editado com sucesso", planoCobranca.Id);

                return Result.Ok();
            } catch (Exception exc) {

                string msgErro = "Falha ao tentar editar plano de Cobrança.";

                Log.Error(exc, msgErro + "{@d}", planoCobranca);

                return Result.Fail(msgErro);
            }
        }

        public Result Excluir(PlanoCobranca planoCobranca) {

            Log.Debug("Tentando excluir plano de Cobrança...{@d}", planoCobranca);

            try {
                bool planoCobrancaExiste = repositorioPlanoCobranca.Existe(planoCobranca);

                if (planoCobrancaExiste == false) {
                    Log.Warning("Plano de Cobrança {PlanoCobrancaId} não encontrado para excluir", planoCobranca.Id);

                    return Result.Fail("Plano de Cobrança não encontrada");
                }

                planoCobranca.grupo.ExcluirPlano(planoCobranca);
                repositorioPlanoCobranca.Excluir(planoCobranca);

                Log.Debug("Plano de Cobrança {PlanoCobrancaId} excluído com sucesso", planoCobranca.Id);

                return Result.Ok();
            } catch (Exception ex) {
                List<string> erros = new List<string>();

                string msgErro;

                msgErro = "Falha ao tentar excluir planoCobranca";

                erros.Add(msgErro);

                Log.Error(ex, msgErro + " {PlanoCobrancaId}", planoCobranca.Id);

                return Result.Fail(erros);
            }
        }

        private List<string> ValidarPlanoCobranca(PlanoCobranca planoCobranca) {
            var resultadoValidacao = validadorPlanoCobranca.Validate(planoCobranca);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            //if (NomeDuplicado(planoCobranca))
            //    erros.Add($"Este nome '{planoCobranca.Nome}' já está sendo utilizado");

            foreach (string erro in erros) {
                Log.Warning(erro);
            }


            return erros;
        }
        
        

        //private bool NomeDuplicado(PlanoCobranca planoCobranca) {
        //    PlanoCobranca planoCobrancaEncontrado = repositorioPlanoCobranca.SelecionarPorNome(planoCobranca.Nome);

        //    if (planoCobrancaEncontrado != null &&
        //        planoCobrancaEncontrado.Id != planoCobranca.Id &&
        //        planoCobrancaEncontrado.Nome == planoCobranca.Nome &&
        //        planoCobrancaEncontrado.Salario == planoCobrancaEncontrado.Salario &&
        //        planoCobrancaEncontrado.DataAdmissao == planoCobrancaEncontrado.DataAdmissao) {
        //        return true;
        //    }

        //    return false;
        //}
    }
}
