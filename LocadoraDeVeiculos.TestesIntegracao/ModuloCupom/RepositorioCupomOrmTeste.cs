using FizzWare.NBuilder;
using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.TestesIntegracao.Compartilhado;


namespace LocadoraDeVeiculos.TestesIntegracao.ModuloCupom
{
    [TestClass]
    public class RepositorioCupomOrmTeste : TesteIntegracaoBase
    {

        [TestMethod]
        public void Deve_inserir_cupom()
        {
            //arrange
            var cupom = Builder<Cupom>.CreateNew().Build();

            //action
            repositorioCupom.Inserir(cupom);

            //assert
            repositorioCupom.SelecionarPorId(cupom.Id).Should().Be(cupom);
        }

        [TestMethod]
        public void Deve_editar_cupom()
        {
            //arrange
            var cupomId = Builder<Cupom>.CreateNew().Persist().Id;

            var cupom = repositorioCupom.SelecionarPorId(cupomId);
            cupom.Nome = "Deko";

            //action
            repositorioCupom.Editar(cupom);

            //assert
            repositorioCupom.SelecionarPorId(cupom.Id)
                .Should().Be(cupom);
        }

        [TestMethod]
        public void Deve_excluir_cupom()
        {
            //arrange
            var cupom = Builder<Cupom>.CreateNew().Persist();

            //action
            repositorioCupom.Excluir(cupom);

            //assert
            repositorioCupom.SelecionarPorId(cupom.Id).Should().BeNull();
        }

        [TestMethod]
        public void Deve_selecionar_todas_cupom()
        {
            //arrange
            var matematica = Builder<Cupom>.CreateNew().With(x => x.Nome = "Matemática").Persist();
            var portugues = Builder<Cupom>.CreateNew().With(x => x.Nome = "Português").Persist();

            //action
            var cupons = repositorioCupom.SelecionarTodos();

            //assert
            cupons.Should().ContainInOrder(matematica, portugues);
            cupons.Should().HaveCount(2);
        }



        [TestMethod]
        public void Deve_selecionar_cupom_por_nome()
        {
            //arrange
            var deko = Builder<Cupom>.CreateNew().Persist();

            //action
            var cupomEncontrado = repositorioCupom.SelecionarPorNome(deko.Nome);

            //assert
            cupomEncontrado.Should().Be(deko);
        }

        [TestMethod]
        public void Deve_selecionar_cupom_por_id()
        {
            //arrange
            var deko = Builder<Cupom>.CreateNew().Persist();

            //action
            var cupomEncontrado = repositorioCupom.SelecionarPorId(deko.Id);

            //assert            
            cupomEncontrado.Should().Be(deko);
        }

    }
}
