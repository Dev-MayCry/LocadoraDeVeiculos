
using FluentAssertions;
using FluentResults;
using FluentResults.Extensions.FluentAssertions;
using LocadoraDeVeiculos.Aplicacao.ModuloParceiro;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using Moq;

namespace LocadoraDeVeiculos.TestesUnitarios.Aplicacao.ModuloParceiro {

    [TestClass]
    public  class ServicoParceiroTest {

        Mock<IRepositorioParceiro> repositorioParceiroMoq;
        Mock<IValidadorParceiro> validadorMoq;

        private ServicoParceiro servicoParceiro;

        Parceiro parceiro;

        public ServicoParceiroTest() {
            repositorioParceiroMoq = new Mock<IRepositorioParceiro>();
            validadorMoq = new Mock<IValidadorParceiro>();
            servicoParceiro = new ServicoParceiro(repositorioParceiroMoq.Object, validadorMoq.Object);
            parceiro = new Parceiro("Desconto do Deko");
        }

        [TestMethod]
        public void Deve_inserir_parceiro_caso_ela_for_valido() //cenário 1
        {
            //arrange
            parceiro = new Parceiro("Desconto do Deko");

            //action
            Result resultado = servicoParceiro.Inserir(parceiro);

            //assert 
            resultado.Should().BeSuccess();
            repositorioParceiroMoq.Verify(x => x.Inserir(parceiro), Times.Once());
        }
    }
}
