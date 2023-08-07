using FizzWare.NBuilder;
using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.TestesIntegracao.Compartilhado;

namespace LocadoraDeVeiculos.TestesIntegracao.ModuloAutomovel {
    
    [TestClass]
    public class RepositorioAutomovelOrmTest : TesteIntegracaoBase{
        [TestMethod]
        public void Deve_inserir_automovel() {
            //arrange
            var grupoAutomovel = Builder<GrupoAutomovel>.CreateNew().Persist();
            var automovel = Builder<Automovel>.CreateNew().With(x => x.GrupoAutomovel = grupoAutomovel).Build();

            //action
            repositorioAutomovel.Inserir(automovel);

            //assert
            repositorioAutomovel.SelecionarPorId(automovel.Id).Should().Be(automovel);
        }
        [TestMethod]
        public void Deve_editar_automovel() {
            //arrange
            var grupoAutomovel = Builder<GrupoAutomovel>.CreateNew().Persist();
            var automovel = Builder<Automovel>.CreateNew().With(x => x.GrupoAutomovel = grupoAutomovel).Persist();

            automovel.Placa = "AAA0000";

            //action
            repositorioAutomovel.Editar(automovel);

            //assert
            repositorioAutomovel.SelecionarPorId(automovel.Id).Should().Be(automovel);
        }

        [TestMethod]
        public void Deve_excluir_automovel() {
            //arrange
            var grupoAutomovel = Builder<GrupoAutomovel>.CreateNew().Persist();
            var automovel = Builder<Automovel>.CreateNew().With(x => x.GrupoAutomovel = grupoAutomovel).Persist();

            //action
            repositorioAutomovel.Excluir(automovel);

            //assert
            repositorioAutomovel.SelecionarPorId(automovel.Id).Should().BeNull();
        }

        [TestMethod]
        public void Deve_selecionar_todos_automoveis() {
            //arrange
            var grupoAutomovel = Builder<GrupoAutomovel>.CreateNew().Persist();
            var matematica = Builder<Automovel>.CreateNew().With(x => x.Placa = "AAA0000").With(x => x.GrupoAutomovel = grupoAutomovel).Persist();
            var portugues = Builder<Automovel>.CreateNew().With(x => x.Placa = "AAA0A000").With(x => x.GrupoAutomovel = grupoAutomovel).Persist();

            //action
            var automovel = repositorioAutomovel.SelecionarTodos();

            //assert
            automovel.Should().ContainInOrder(matematica, portugues);
            automovel.Should().HaveCount(2);
        }

        [TestMethod]
        public void Deve_selecionar_automovel_por_placa() {
            //arrange
            var grupoAutomovel = Builder<GrupoAutomovel>.CreateNew().Persist();
            var matematica = Builder<Automovel>.CreateNew().With(x => x.GrupoAutomovel = grupoAutomovel).Persist();

            //action
            var automovelsEncontrados = repositorioAutomovel.SelecionarPorPlaca(matematica.Placa);

            //assert
            automovelsEncontrados.Should().Be(matematica);
        }

        [TestMethod]
        public void Deve_selecionar_automovel_por_id() {
            //arrange
            var grupoAutomovel = Builder<GrupoAutomovel>.CreateNew().Persist();
            var matematica = Builder<Automovel>.CreateNew().With(x => x.GrupoAutomovel = grupoAutomovel).Persist();

            //action
            var automovelsEncontrada = repositorioAutomovel.SelecionarPorId(matematica.Id);

            //assert            
            automovelsEncontrada.Should().Be(matematica);
        }
    }
}
