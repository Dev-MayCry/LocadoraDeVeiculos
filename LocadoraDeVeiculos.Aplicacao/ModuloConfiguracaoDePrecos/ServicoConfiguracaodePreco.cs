using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloConfiguracaoDePrecos;
using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Aplicacao.ModuloConfiguracaoDePrecos {
    public class ServicoConfiguracaodePreco {

        private IRepositorioConfiguracaoPreco repositorioConfiguracaoPreco;
        private IValidadorConfiguradorPreco validadorConfiguracaoPreco;

        public ServicoConfiguracaodePreco(IRepositorioConfiguracaoPreco repositorioConfiguracaoPreco, IValidadorConfiguradorPreco validadorConfiguracaoPreco) {

            this.repositorioConfiguracaoPreco = repositorioConfiguracaoPreco;
            this.validadorConfiguracaoPreco = validadorConfiguracaoPreco;

        }


        public Result Inserir(ConfiguracaoDePreco configuracaoDePreco) {
            Log.Debug("Tentando inserir parceiro...{@d}", configuracaoDePreco);

            List<string> erros = ValidarConfigurador(configuracaoDePreco);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try {
                repositorioConfiguracaoPreco.Inserir(configuracaoDePreco);

                Log.Debug("Cupom {CupomId} inserida com sucesso", configuracaoDePreco.Id);

                return Result.Ok(); //cenário 1
            } catch (Exception exc) {
                string msgErro = "Falha ao tentar inserir Cupom.";

                Log.Error(exc, msgErro + "{@d}", configuracaoDePreco);

                return Result.Fail(msgErro); //cenário 3
            }
        }
        public Result Editar(ConfiguracaoDePreco configuracaoDePreco) {
            Log.Debug("Tentando editar parceiro...{@d}", configuracaoDePreco);

            List<string> erros = ValidarConfigurador(configuracaoDePreco);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try {
                repositorioConfiguracaoPreco.Editar(configuracaoDePreco);

                Log.Debug("Parceiro {ParceiroId} editado com sucesso", configuracaoDePreco.Id);

                return Result.Ok();
            } catch (Exception exc) {
                string msgErro = "Falha ao tentar editar configuração de preço.";

                Log.Error(exc, msgErro + "{@d}", configuracaoDePreco);

                return Result.Fail(msgErro);
            }
        }

        private List<string> ValidarConfigurador(ConfiguracaoDePreco configurador) {
            var resultadoValidacao = validadorConfiguracaoPreco.Validate(configurador);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));


            foreach (string erro in erros) {
                Log.Warning(erro);
            }

            return erros;
        }
    }
}
