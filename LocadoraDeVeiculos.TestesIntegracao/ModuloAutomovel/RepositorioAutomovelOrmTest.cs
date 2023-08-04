using FizzWare.NBuilder;
using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.TestesIntegracao.Compartilhado;

namespace LocadoraDeVeiculos.TestesIntegracao.ModuloAutomovel {
    
    [TestClass]
    public class RepositorioAutomovelOrmTest : TesteIntegracaoBase{
        [TestMethod]
        public void Deve_inserir_automovel() {
            //arrange
            var automovel = Builder<Automovel>.CreateNew().Build();

            //action
            repositorioAutomovel.Inserir(automovel);

            //assert
            repositorioAutomovel.SelecionarPorId(automovel.Id).Should().Be(automovel);
        }
        [TestMethod]
        public void Deve_editar_automovel() {
            //arrange
            var automovelId = Builder<Automovel>.CreateNew().Persist().Id;

            var automovel = repositorioAutomovel.SelecionarPorId(automovelId);
            automovel.Placa = "AAA0000";

            //action
            repositorioAutomovel.Editar(automovel);

            //assert
            repositorioAutomovel.SelecionarPorId(automovel.Id).Should().Be(automovel);
        }

        [TestMethod]
        public void Deve_excluir_automovel() {
            //arrange
            var automovel = Builder<Automovel>.CreateNew().Persist();

            //action
            repositorioAutomovel.Excluir(automovel);

            //assert
            repositorioAutomovel.SelecionarPorId(automovel.Id).Should().BeNull();
        }

        [TestMethod]
        public void Deve_selecionar_todos_automovels() {
            //arrange
            var matematica = Builder<Automovel>.CreateNew().With(x => x.Placa = "AAA0000").Persist();
            var portugues = Builder<Automovel>.CreateNew().With(x => x.Placa = "AAA0A000").Persist();

            //action
            var automovel = repositorioAutomovel.SelecionarTodos();

            //assert
            automovel.Should().ContainInOrder(matematica, portugues);
            automovel.Should().HaveCount(2);
        }

        [TestMethod]
        public void Deve_selecionar_automovel_por_nome() {
            //arrange
            var matematica = Builder<Automovel>.CreateNew().Persist();

            //action
            var automovelsEncontrados = repositorioAutomovel.SelecionarPorPlaca(matematica.Placa);

            //assert
            automovelsEncontrados.Should().Be(matematica);
        }

        [TestMethod]
        public void Deve_selecionar_automovel_por_id() {
            //arrange
            var matematica = Builder<Automovel>.CreateNew().Persist();

            //action
            var automovelsEncontrada = repositorioAutomovel.SelecionarPorId(matematica.Id);

            //assert            
            automovelsEncontrada.Should().Be(matematica);
        }
    }
}
