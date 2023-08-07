using FluentAssertions;
using FluentAssertions.Equivalency;
using FluentResults;
using FluentResults.Extensions.FluentAssertions;
using LocadoraDeVeiculos.Aplicacao.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Aplicacao.ModuloPlanoCobranca;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using Moq;

namespace LocadoraDeVeiculos.TestesUnitarios.Aplicacao.ModuloPlanoCobranca {

    [TestClass]
    public class ServicoPlanoCobrancaTest {

        Mock<IRepositorioPlanoCobranca> repositorioPlanoCobrancaMoq;
        Mock<IValidadorPlanoCobranca> validadorMoq;

        private ServicoPlanoCobranca servicoPlanoCobranca;

        PlanoCobranca plano;
        GrupoAutomovel grupo;

        public ServicoPlanoCobrancaTest() {
            repositorioPlanoCobrancaMoq = new Mock<IRepositorioPlanoCobranca>();
            validadorMoq = new Mock<IValidadorPlanoCobranca>(); ;
            servicoPlanoCobranca = new ServicoPlanoCobranca(repositorioPlanoCobrancaMoq.Object, validadorMoq.Object);
            grupo = new ("SUV");
        }

        [TestMethod]
        public void Deve_inserir_plano_caso_ele_for_valido() //cenário 1
        {
            //arrange
            plano = new PlanoCobranca();
            plano.grupo = grupo;
            plano.PrecoDiaria = 20;
            plano.PrecoKm = 5;
            plano.KmDisponiveis = 300;
            plano.tipo = TipoPlanoEnum.PlanoControlador;

            //action
            Result resultado = servicoPlanoCobranca.Inserir(plano);

            //assert 
            resultado.Should().BeSuccess();
            repositorioPlanoCobrancaMoq.Verify(x => x.Inserir(plano), Times.Once());
        }

        [TestMethod]
        public void Não_deve_inserir_se_o_grupo_ja_tiver_o_mesmo_plano_ja_cadastrado() {
            plano = new PlanoCobranca();
            plano.grupo = grupo;
            plano.PrecoDiaria = 20;
            plano.PrecoKm = 5;
            plano.KmDisponiveis = 300;
            plano.tipo = TipoPlanoEnum.PlanoControlador;

            PlanoCobranca plano2 = plano;
            plano2.grupo = grupo;
            plano2.PrecoDiaria = 20;
            plano2.PrecoKm = 5;
            plano2.KmDisponiveis = 300;
            plano2.tipo = TipoPlanoEnum.PlanoControlador;

            //action
            servicoPlanoCobranca.Inserir(plano);
            Result resultado = servicoPlanoCobranca.Inserir(plano2);

            //assert 
            resultado.Should().BeFailure();
            resultado.Reasons[0].Message.Should().Be("O grupo selecionado já possui esse modelo de cobrança!");
            repositorioPlanoCobrancaMoq.Verify(x => x.Inserir(plano), Times.Once());
        }

        [TestMethod]
        public void Deve_permitir_inserir_o_mesmo_plano_no_grupo_depois_de_excluido() {

            plano = new PlanoCobranca();
            plano.grupo = grupo;
            plano.PrecoDiaria = 20;
            plano.PrecoKm = 5;
            plano.KmDisponiveis = 300;
            plano.tipo = TipoPlanoEnum.PlanoControlador;

            PlanoCobranca plano2 = plano;
            plano2.grupo = grupo;
            plano2.PrecoDiaria = 20;
            plano2.PrecoKm = 5;
            plano2.KmDisponiveis = 300;
            plano2.tipo = TipoPlanoEnum.PlanoControlador;

            servicoPlanoCobranca.Inserir(plano);

            repositorioPlanoCobrancaMoq.Setup(x => x.Existe(plano))
               .Returns(() => {
                   return true;
               });

            //action
            
            servicoPlanoCobranca.Excluir(plano);
            Result resultado = servicoPlanoCobranca.Inserir(plano2);

            //assert 
            resultado.Should().BeSuccess();
            
            repositorioPlanoCobrancaMoq.Verify(x => x.Inserir(plano), Times.Exactly(2));
        }

        [TestMethod]
        public void Deve_editar_plano_caso_ele_for_valido() 
        {
            //arrange           
            plano = new PlanoCobranca();
            plano.grupo = grupo;
            plano.PrecoDiaria = 20;
            plano.PrecoKm = 5;
            plano.KmDisponiveis = 300;
            plano.tipo = TipoPlanoEnum.PlanoControlador;

            //action
            Result resultado = servicoPlanoCobranca.Editar(plano);

            //assert 
            resultado.Should().BeSuccess();
            repositorioPlanoCobrancaMoq.Verify(x => x.Editar(plano), Times.Once());
        }

        [TestMethod]
        public void Deve_excluir_plano_caso_ele_esteja_cadastrado() //cenário 1
        {
            //arrange
            plano = new PlanoCobranca();
            plano.grupo = grupo;
            plano.PrecoDiaria = 20;
            plano.PrecoKm = 5;
            plano.KmDisponiveis = 300;
            plano.tipo = TipoPlanoEnum.PlanoControlador;

            repositorioPlanoCobrancaMoq.Setup(x => x.Existe(plano))
               .Returns(() => {
                   return true;
               });

            //action
            var resultado = servicoPlanoCobranca.Excluir(plano);

            //assert 
            resultado.Should().BeSuccess();
            repositorioPlanoCobrancaMoq.Verify(x => x.Excluir(plano), Times.Once());
        }

        [TestMethod]
        public void Nao_deve_excluir_parceiro_caso_ele_nao_esteja_cadastrado() //cenário 2
        {
            //arrange

            plano = new PlanoCobranca();
            plano.grupo = grupo;
            plano.PrecoDiaria = 20;
            plano.PrecoKm = 5;
            plano.KmDisponiveis = 300;
            plano.tipo = TipoPlanoEnum.PlanoControlador;

            repositorioPlanoCobrancaMoq.Setup(x => x.Existe(plano))
               .Returns(() => {
                   return false;
               });

            //action
            var resultado = servicoPlanoCobranca.Excluir(plano);

            //assert 
            resultado.Should().BeFailure();
            repositorioPlanoCobrancaMoq.Verify(x => x.Excluir(plano), Times.Never());
        }


    }
}
