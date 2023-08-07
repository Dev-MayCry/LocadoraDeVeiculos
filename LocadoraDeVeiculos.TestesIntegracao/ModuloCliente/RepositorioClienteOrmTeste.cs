using FizzWare.NBuilder;
using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.TestesIntegracao.Compartilhado;


namespace LocadoraDeVeiculos.TestesIntegracao.ModuloCliente
{
    internal class RepositorioClienteOrmTeste : TesteIntegracaoBase
    {

        [TestMethod]
        public void Deve_inserir_cliente()
        {
            //arrange
            var cliente = Builder<Cliente>.CreateNew().Build();

            //action
            repositorioCliente.Inserir(cliente);

            //assert
            repositorioCliente.SelecionarPorId(cliente.Id).Should().Be(cliente);
        }

        [TestMethod]
        public void Deve_editar_cliente()
        {
            //arrange
            var clienteId = Builder<Cliente>.CreateNew().Persist().Id;

            var cliente = repositorioCliente.SelecionarPorId(clienteId);
            cliente.Nome = "Deko";

            //action
            repositorioCliente.Editar(cliente);

            //assert
            repositorioCliente.SelecionarPorId(cliente.Id)
                .Should().Be(cliente);
        }

        [TestMethod]
        public void Deve_excluir_cliente()
        {
            //arrange
            var cliente = Builder<Cliente>.CreateNew().Persist();

            //action
            repositorioCliente.Excluir(cliente);

            //assert
            repositorioCliente.SelecionarPorId(cliente.Id).Should().BeNull();
        }

        [TestMethod]
        public void Deve_selecionar_todas_clientes()
        {
            //arrange
            var matematica = Builder<Cliente>.CreateNew().With(x => x.Nome = "Matemática").Persist();
            var portugues = Builder<Cliente>.CreateNew().With(x => x.Nome = "Português").Persist();

            //action
            var clientes = repositorioCliente.SelecionarTodos();

            //assert
            clientes.Should().ContainInOrder(clientes);
            clientes.Should().HaveCount(2);
        }



        [TestMethod]
        public void Deve_selecionar_cliente_por_nome()
        {
            //arrange
            var deko = Builder<Cliente>.CreateNew().Persist();

            //action
            var clientesEncontrado = repositorioCliente.SelecionarPorNome(deko.Nome);

            //assert
            clientesEncontrado.Should().Be(deko);
        }

        [TestMethod]
        public void Deve_selecionar_cliente_por_id()
        {
            //arrange
            var deko = Builder<Cliente>.CreateNew().Persist();

            //action
            var clientesEncontrado = repositorioCliente.SelecionarPorId(deko.Id);

            //assert            
            clientesEncontrado.Should().Be(deko);
        }
    }   
}
