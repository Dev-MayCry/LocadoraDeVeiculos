using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ModuloTaxaServico;

namespace LocadoraDeVeiculos.TestesUnitarios.Dominio.ModuloTaxaServico {

    [TestClass]
    public class TaxaServicoTest {
        TaxaServico taxaServico;

        public TaxaServicoTest() {
            taxaServico = new("Limpeza", 20, TipoPlanoCalculoEnum.PrecoFixo);
        }

        [TestMethod]
        public void Nome_deve_ser_diferente_de_null() {
            taxaServico.Nome.Should().NotBeNull();
        }
    }
}
