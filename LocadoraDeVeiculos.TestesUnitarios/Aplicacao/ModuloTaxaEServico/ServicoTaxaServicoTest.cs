using FluentAssertions;
using FluentResults;
using FluentResults.Extensions.FluentAssertions;
using LocadoraDeVeiculos.Aplicacao.ModuloTaxaServico;
using LocadoraDeVeiculos.Dominio.ModuloTaxaServico;
using Moq;

namespace LocadoraDeVeiculos.TestesUnitarios.Aplicacao.ModuloTaxaEServico {
    [TestClass]
    public class ServicoTaxaServicoTest {
        Mock<IRepositorioTaxaServico> repositorioTaxaServicoMoq;
        Mock<IValidadorTaxaServico> validadorMoq;

        private ServicoTaxaServico servicoTaxaServico;

        TaxaServico taxa;

        public ServicoTaxaServicoTest() {
            repositorioTaxaServicoMoq = new Mock<IRepositorioTaxaServico>();
            validadorMoq = new Mock<IValidadorTaxaServico>(); ;
            servicoTaxaServico = new ServicoTaxaServico(repositorioTaxaServicoMoq.Object, validadorMoq.Object);
            taxa = new("Limpeza", 20, TipoPlanoCalculoEnum.PrecoFixo);
        }

        [TestMethod]
        public void Deve_inserir_taxa_caso_ele_for_valido() //cenário 1
        {
            //arrange
            taxa = new TaxaServico("Limpeza", 20, TipoPlanoCalculoEnum.PrecoFixo);

            //action
            Result resultado = servicoTaxaServico.Inserir(taxa);

            //assert 
            resultado.Should().BeSuccess();
            repositorioTaxaServicoMoq.Verify(x => x.Inserir(taxa), Times.Once());
        }

        [TestMethod]
        public void Nao_deve_inserir_taxa_caso_o_nome_ja_esteja_cadastrado() //cenário 2
        {
            //arrange
            string nome = "Limpeza";
            repositorioTaxaServicoMoq.Setup(x => x.SelecionarPorNome(nome))
                .Returns(() => {
                    return new TaxaServico(nome, 20, TipoPlanoCalculoEnum.PrecoFixo);
                });

            //action
            var resultado = servicoTaxaServico.Inserir(taxa);

            //assert 
            resultado.Should().BeFailure();
            resultado.Reasons[0].Message.Should().Be($"Este nome '{nome}' já está sendo utilizado");
            repositorioTaxaServicoMoq.Verify(x => x.Inserir(taxa), Times.Never());
        }

        [TestMethod]
        public void Deve_tratar_erro_caso_ocorra_falha_ao_tentar_inserir_taxa() //cenário 3
        {
            repositorioTaxaServicoMoq.Setup(x => x.Inserir(It.IsAny<TaxaServico>()))
                .Throws(() => {
                    return new Exception();
                });

            //action
            Result resultado = servicoTaxaServico.Inserir(taxa);

            //assert 
            resultado.Should().BeFailure();
            resultado.Reasons[0].Message.Should().Be("Falha ao tentar inserir taxa.");
        }

        [TestMethod]
        public void Deve_editar_taxa_caso_ele_for_valido() //cenário 1
        {
            //arrange           
            taxa = new TaxaServico("Sujeiras", 20, TipoPlanoCalculoEnum.PrecoFixo);

            //action
            Result resultado = servicoTaxaServico.Editar(taxa);

            //assert 
            resultado.Should().BeSuccess();
            repositorioTaxaServicoMoq.Verify(x => x.Editar(taxa), Times.Once());
        }

        [TestMethod]
        public void Deve_editar_taxa_com_o_mesmo_nome() //cenário 2
        {
            //arrange

            Guid id = new Guid();
            repositorioTaxaServicoMoq.Setup(x => x.SelecionarPorNome("Desconto do Deko"))
                 .Returns(() => {
                     return new TaxaServico(id, "Limpeza", 20, TipoPlanoCalculoEnum.PrecoFixo);
                 });

            TaxaServico outroGrupo = new TaxaServico(id, "Limpeza", 20, TipoPlanoCalculoEnum.PrecoFixo);

            //action
            var resultado = servicoTaxaServico.Editar(outroGrupo);

            //assert 
            resultado.Should().BeSuccess();

            repositorioTaxaServicoMoq.Verify(x => x.Editar(outroGrupo), Times.Once());
        }

        [TestMethod]
        public void Nao_deve_editar_taxa_caso_o_nome_ja_esteja_cadastrado() //cenário 3
        {
            //arrange
            repositorioTaxaServicoMoq.Setup(x => x.SelecionarPorNome("Limpeza"))
                 .Returns(() => {
                     return new TaxaServico("Limpeza", 20, TipoPlanoCalculoEnum.PrecoFixo);
                 });

            TaxaServico novoGrupo = new TaxaServico("Limpeza", 20, TipoPlanoCalculoEnum.PrecoFixo);

            //action
            var resultado = servicoTaxaServico.Editar(novoGrupo);

            //assert 
            resultado.Should().BeFailure();

            repositorioTaxaServicoMoq.Verify(x => x.Editar(novoGrupo), Times.Never());
        }

        [TestMethod]
        public void Deve_tratar_erro_caso_ocorra_falha_ao_tentar_editar_taxa() //cenário 4
        {
            repositorioTaxaServicoMoq.Setup(x => x.Editar(It.IsAny<TaxaServico>()))
                .Throws(() => {
                    return new Exception();
                });

            //action
            Result resultado = servicoTaxaServico.Editar(taxa);

            //assert 
            resultado.Should().BeFailure();
            resultado.Errors[0].Message.Should().Be("Falha ao tentar editar taxa.");
        }

        [TestMethod]
        public void Deve_excluir_taxa_caso_ele_esteja_cadastrado() //cenário 1
        {
            //arrange
            var taxa = new TaxaServico("Limpeza", 20, TipoPlanoCalculoEnum.PrecoFixo);

            repositorioTaxaServicoMoq.Setup(x => x.Existe(taxa))
               .Returns(() => {
                   return true;
               });

            //action
            var resultado = servicoTaxaServico.Excluir(taxa);

            //assert 
            resultado.Should().BeSuccess();
            repositorioTaxaServicoMoq.Verify(x => x.Excluir(taxa), Times.Once());
        }

        [TestMethod]
        public void Nao_deve_excluir_taxa_caso_ele_nao_esteja_cadastrado() //cenário 2
        {
            //arrange

            var taxa = new TaxaServico("Limpeza", 20, TipoPlanoCalculoEnum.PrecoFixo);

            repositorioTaxaServicoMoq.Setup(x => x.Existe(taxa))
               .Returns(() => {
                   return false;
               });

            //action
            var resultado = servicoTaxaServico.Excluir(taxa);

            //assert 
            resultado.Should().BeFailure();
            repositorioTaxaServicoMoq.Verify(x => x.Excluir(taxa), Times.Never());
        }
    }
}
