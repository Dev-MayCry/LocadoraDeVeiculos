using FizzWare.NBuilder;
using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.TestesIntegracao.Compartilhado;
using System.Drawing.Drawing2D;

namespace LocadoraDeVeiculos.TestesIntegracao.ModuloParceiro {
    [TestClass]
    public class RepositorioParceiroOrmTest : TesteIntegracaoBase {

        [TestMethod]
        public void Deve_inserir_parceiro() {
            //arrange
            var parceiro = Builder<Parceiro>.CreateNew().Build();

            //action
            repositorioCliente.Inserir(parceiro);

            //assert
            repositorioCliente.SelecionarPorId(parceiro.Id).Should().Be(parceiro);
        }

        [TestMethod]
        public void Deve_editar_parceiro() {
            //arrange
            var parceiroId = Builder<Parceiro>.CreateNew().Persist().Id;

            var parceiro = repositorioCliente.SelecionarPorId(parceiroId);
            parceiro.Nome = "Deko";

            //action
            repositorioCliente.Editar(parceiro);

            //assert
            repositorioCliente.SelecionarPorId(parceiro.Id)
                .Should().Be(parceiro);
        }

        [TestMethod]
        public void Deve_excluir_parceiro() {
            //arrange
            var parceiro = Builder<Parceiro>.CreateNew().Persist();

            //action
            repositorioCliente.Excluir(parceiro);

            //assert
            repositorioCliente.SelecionarPorId(parceiro.Id).Should().BeNull();
        }

        [TestMethod]
        public void Deve_selecionar_todas_parceiros() {
            //arrange
            var matematica = Builder<Parceiro>.CreateNew().With(x => x.Nome = "Matemática").Persist();
            var portugues = Builder<Parceiro>.CreateNew().With(x => x.Nome = "Português").Persist();

            //action
            var parceiros = repositorioCliente.SelecionarTodos();

            //assert
            parceiros.Should().ContainInOrder(matematica, portugues);
            parceiros.Should().HaveCount(2);
        }

     

        [TestMethod]
        public void Deve_selecionar_parceiro_por_nome() {
            //arrange
            var deko = Builder<Parceiro>.CreateNew().Persist();

            //action
            var parceirosEncontrado = repositorioCliente.SelecionarPorNome(deko.Nome);

            //assert
            parceirosEncontrado.Should().Be(deko);
        }

        [TestMethod]
        public void Deve_selecionar_parceiro_por_id() {
            //arrange
            var deko = Builder<Parceiro>.CreateNew().Persist();

            //action
            var parceirosEncontrado = repositorioCliente.SelecionarPorId(deko.Id);

            //assert            
            parceirosEncontrado.Should().Be(deko);
        }




    }
}
