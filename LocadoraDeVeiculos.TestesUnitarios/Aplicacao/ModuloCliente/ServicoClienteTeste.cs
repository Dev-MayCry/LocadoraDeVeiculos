using FluentAssertions;
using FluentResults;
using LocadoraDeVeiculos.Aplicacao.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using Moq;


namespace LocadoraDeVeiculos.TestesUnitarios.Aplicacao.ModuloCliente
{
    [TestClass]
    public class ServicoClienteTeste
    {

        Mock<IRepositorioCliente> repositorioClienteMoq;
        Mock<IValidadorCliente> validadorMoq;

        private ServicoCliente servicoCliente;

        Cliente cliente;

        public ServicoClienteTeste()
        {
            repositorioClienteMoq = new Mock<IRepositorioCliente>();
            validadorMoq = new Mock<IValidadorCliente>();
            servicoCliente = new ServicoCliente(repositorioClienteMoq.Object, validadorMoq.Object);
            cliente = new Cliente("Desconto do Deko");
        }

        [TestMethod]
        public void Deve_inserir_cliente_caso_ela_for_valido() //cenário 1
        {
            //arrange
            cliente = new Cliente("Desconto do Deko");

            //action
            Result resultado = servicoCliente.Inserir(cliente);

            //assert 
            resultado.Should().BeSuccess();
            repositorioClienteMoq.Verify(x => x.Inserir(cliente), Times.Once());
        }

        [TestMethod]
        public void Nao_deve_inserir_cliente_caso_o_nome_ja_esteja_cadastrado() //cenário 3
        {
            //arrange
            string nomeCliente = "Desconto do Deko";
            repositorioClienteMoq.Setup(x => x.SelecionarPorNome(nomeCliente))
                .Returns(() => {
                    return new Cliente(nomeCliente);
                });

            //action
            var resultado = servicoCliente.Inserir(cliente);

            //assert 
            resultado.Should().BeFailure();
            resultado.Reasons[0].Message.Should().Be($"Este nome '{nomeCliente}' já está sendo utilizado");
            repositorioClienteMoq.Verify(x => x.Inserir(cliente), Times.Never());
        }

        [TestMethod]
        public void Deve_tratar_erro_caso_ocorra_falha_ao_tentar_inserir_cliente() //cenário 4
        {
            repositorioClienteMoq.Setup(x => x.Inserir(It.IsAny<Cliente>()))
                .Throws(() => {
                    return new Exception();
                });

            //action
            Result resultado = servicoCliente.Inserir(cliente);

            //assert 
            resultado.Should().BeFailure();
            resultado.Reasons[0].Message.Should().Be("Falha ao tentar inserir cliente.");
        }

        [TestMethod]
        public void Deve_editar_cliente_caso_ele_for_valido() //cenário 1
        {
            //arrange           
            cliente = new Cliente("iFood");

            //action
            Result resultado = servicoCliente.Editar(cliente);

            //assert 
            resultado.Should().BeSuccess();
            repositorioClienteMoq.Verify(x => x.Editar(cliente), Times.Once());
        }

        [TestMethod]
        public void Deve_editar_Cliente_com_o_mesmo_nome() //cenário 3
        {
            //arrange
            Guid id = new Guid();
            repositorioClienteMoq.Setup(x => x.SelecionarPorNome("Desconto do Deko"))
                 .Returns(() => {
                     return new Parceiro(id, "Desconto do Deko");
                 });

            Cliente outroCliente = new Cliente(id, "Desconto do Deko");

            //action
            var resultado = servicoCliente.Editar(outroCliente);

            //assert 
            resultado.Should().BeSuccess();

            repositorioClienteMoq.Verify(x => x.Editar(outroCliente), Times.Once());
        }

        [TestMethod]
        public void Nao_deve_editar_Cliente_caso_o_nome_ja_esteja_cadastrado() //cenário 4
        {
            //arrange
            repositorioClienteMoq.Setup(x => x.SelecionarPorNome("Desconto do Deko"))
                 .Returns(() => {
                     return new Cliente("Desconto do Deko");
                 });

            Cliente novoCliente = new Cliente("Desconto do Deko");

            //action
            var resultado = servicoCliente.Editar(novoCliente);

            //assert 
            resultado.Should().BeFailure();

            repositorioClienteMoq.Verify(x => x.Editar(novoCliente), Times.Never());
        }

        [TestMethod]
        public void Deve_tratar_erro_caso_ocorra_falha_ao_tentar_editar_Cliente() //cenário 5
        {
            repositorioClienteMoq.Setup(x => x.Editar(It.IsAny<Cliente>()))
                .Throws(() => {
                    return new Exception();
                });

            //action
            Result resultado = servicoCliente.Editar(cliente);

            //assert 
            resultado.Should().BeFailure();
            resultado.Errors[0].Message.Should().Be("Falha ao tentar editar cliente.");
        }

        [TestMethod]
        public void Deve_excluir_cliente_caso_ele_esteja_cadastrado() //cenário 1
        {
            //arrange
            var cliente = new Cliente("Desconto do Deko");

            repositorioClienteMoq.Setup(x => x.Existe(cliente))
               .Returns(() => {
                   return true;
               });

            //action
            var resultado = servicoCliente.Excluir(cliente);

            //assert 
            resultado.Should().BeSuccess();
            repositorioClienteMoq.Verify(x => x.Excluir(cliente), Times.Once());
        }

        [TestMethod]
        public void Nao_deve_excluir_cliente_caso_ele_nao_esteja_cadastrado() //cenário 2
        {
            //arrange

            var parceiro = new Parceiro("Desconto do Deko");

            repositorioClienteMoq.Setup(x => x.Existe(cliente))
               .Returns(() => {
                   return false;
               });

            //action
            var resultado = servicoCliente.Excluir(parceiro);

            //assert 
            resultado.Should().BeFailure();
            repositorioClienteMoq.Verify(x => x.Excluir(cliente), Times.Never());
        }


    }

}
