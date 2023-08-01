using FizzWare.NBuilder;
using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.TestesIntegracao.Compartilhado;

namespace LocadoraDeVeiculos.TestesIntegracao.ModuloParceiro {
    [TestClass]
    public class RepositorioParceiroOrmTest : TesteIntegracaoBase {

        [TestMethod]
        public void Deve_inserir_parceiro() {
            //arrange
            var parceiro = Builder<Parceiro>.CreateNew().Build();

            //action
            repositorioParceiro.Inserir(parceiro);

            //assert
            repositorioParceiro.SelecionarPorId(parceiro.Id).Should().Be(parceiro);
        }

        


    }
}
