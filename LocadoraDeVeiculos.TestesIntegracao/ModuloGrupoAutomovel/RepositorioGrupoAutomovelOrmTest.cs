using FizzWare.NBuilder;
using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.TestesIntegracao.Compartilhado;

namespace LocadoraDeVeiculos.TestesIntegracao.ModuloGrupoAutomovel {

    [TestClass]
    public class RepositorioGrupoAutomovelOrmTest : TesteIntegracaoBase{

        [TestMethod]
        public void Deve_inserir_grupo() {
            //arrange
            var grupo = Builder<GrupoAutomovel>.CreateNew().Build();

            //action
            repositorioGrupoAutomovel.Inserir(grupo);

            //assert
            repositorioGrupoAutomovel.SelecionarPorId(grupo.Id).Should().Be(grupo);
        }

        [TestMethod]
        public void Deve_editar_grupo() {
            //arrange
            var grupoId = Builder<GrupoAutomovel>.CreateNew().Persist().Id;

            var grupo = repositorioGrupoAutomovel.SelecionarPorId(grupoId);
            grupo.Nome = "Caminhão Blindão";

            //action
            repositorioGrupoAutomovel.Editar(grupo);

            //assert
            repositorioGrupoAutomovel.SelecionarPorId(grupo.Id).Should().Be(grupo);
        }

        [TestMethod]
        public void Deve_excluir_grupo() {
            //arrange
            var grupo = Builder<GrupoAutomovel>.CreateNew().Persist();

            //action
            repositorioGrupoAutomovel.Excluir(grupo);

            //assert
            repositorioGrupoAutomovel.SelecionarPorId(grupo.Id).Should().BeNull();
        }

        [TestMethod]
        public void Deve_selecionar_todos_grupos() {
            //arrange
            var matematica = Builder<GrupoAutomovel>.CreateNew().With(x => x.Nome = "Matemática").Persist();
            var portugues = Builder<GrupoAutomovel>.CreateNew().With(x => x.Nome = "Português").Persist();

            //action
            var grupo = repositorioGrupoAutomovel.SelecionarTodos();

            //assert
            grupo.Should().ContainInOrder(matematica, portugues);
            grupo.Should().HaveCount(2);
        }

        [TestMethod]
        public void Deve_selecionar_grupo_por_nome()
        {
            //arrange
            var matematica = Builder<GrupoAutomovel>.CreateNew().Persist();

            //action
            var gruposEncontrados = repositorioGrupoAutomovel.SelecionarPorNome(matematica.Nome);

            //assert
            gruposEncontrados.Should().Be(matematica);
        }

        [TestMethod]
        public void Deve_selecionar_grupo_por_id()
        {
            //arrange
            var matematica = Builder<GrupoAutomovel>.CreateNew().Persist();

            //action
            var gruposEncontrada = repositorioGrupoAutomovel.SelecionarPorId(matematica.Id);

            //assert            
            gruposEncontrada.Should().Be(matematica);
        }
    }
}
