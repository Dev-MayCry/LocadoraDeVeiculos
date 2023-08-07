using FluentAssertions;
using FluentResults;
using FluentResults.Extensions.FluentAssertions;
using LocadoraDeVeiculos.Aplicacao.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using Moq;

namespace LocadoraDeVeiculos.TestesUnitarios.Aplicacao.ModuloGrupoAutomovel {

    [TestClass]
    public class ServicoGrupoAutomovelTest {
        Mock<IRepositorioGrupoAutomovel> repositorioGrupoAutomovelMoq;
        Mock<IValidadorGrupoAutomovel> validadorMoq;

        private ServicoGrupoAutomovel servicoGrupoAutomovel;

        GrupoAutomovel grupo;

        public ServicoGrupoAutomovelTest() {
            repositorioGrupoAutomovelMoq = new Mock<IRepositorioGrupoAutomovel>();
            validadorMoq = new Mock<IValidadorGrupoAutomovel>(); ;
            servicoGrupoAutomovel = new ServicoGrupoAutomovel(repositorioGrupoAutomovelMoq.Object, validadorMoq.Object);
            grupo = new("Caminhão Blindão");
        }

        [TestMethod]
        public void Deve_inserir_grupo_caso_ele_for_valido() //cenário 1
        {
            //arrange
            grupo = new GrupoAutomovel("Caminhão Blindão");

            //action
            Result resultado = servicoGrupoAutomovel.Inserir(grupo);

            //assert 
            resultado.Should().BeSuccess();
            repositorioGrupoAutomovelMoq.Verify(x => x.Inserir(grupo), Times.Once());
        }

        [TestMethod]
        public void Nao_deve_inserir_grupo_caso_o_nome_ja_esteja_cadastrado() //cenário 2
        {
            //arrange
            string nome = "Caminhão Blindão";
            repositorioGrupoAutomovelMoq.Setup(x => x.SelecionarPorNome(nome))
                .Returns(() => {
                    return new GrupoAutomovel(nome);
                });

            //action
            var resultado = servicoGrupoAutomovel.Inserir(grupo);

            //assert 
            resultado.Should().BeFailure();
            resultado.Reasons[0].Message.Should().Be($"Este nome '{nome}' já está sendo utilizado");
            repositorioGrupoAutomovelMoq.Verify(x => x.Inserir(grupo), Times.Never());
        }

        [TestMethod]
        public void Deve_tratar_erro_caso_ocorra_falha_ao_tentar_inserir_grupo() //cenário 3
        {
            repositorioGrupoAutomovelMoq.Setup(x => x.Inserir(It.IsAny<GrupoAutomovel>()))
                .Throws(() => {
                    return new Exception();
                });

            //action
            Result resultado = servicoGrupoAutomovel.Inserir(grupo);

            //assert 
            resultado.Should().BeFailure();
            resultado.Reasons[0].Message.Should().Be("Falha ao tentar inserir grupo.");
        }

        [TestMethod]
        public void Deve_editar_grupo_caso_ele_for_valido() //cenário 1
        {
            //arrange           
            grupo = new GrupoAutomovel("iFoof");

            //action
            Result resultado = servicoGrupoAutomovel.Editar(grupo);

            //assert 
            resultado.Should().BeSuccess();
            repositorioGrupoAutomovelMoq.Verify(x => x.Editar(grupo), Times.Once());
        }

        [TestMethod]
        public void Deve_editar_grupo_com_o_mesmo_nome() //cenário 2
        {
            //arrange

            Guid id = new Guid();
            repositorioGrupoAutomovelMoq.Setup(x => x.SelecionarPorNome("Desconto do Deko"))
                 .Returns(() => {
                     return new GrupoAutomovel(id,"Desconto do Deko");
                 });

            GrupoAutomovel outroGrupo = new GrupoAutomovel(id,"Desconto do Deko");

            //action
            var resultado = servicoGrupoAutomovel.Editar(outroGrupo);

            //assert 
            resultado.Should().BeSuccess();

            repositorioGrupoAutomovelMoq.Verify(x => x.Editar(outroGrupo), Times.Once());
        }

        [TestMethod]
        public void Nao_deve_editar_grupo_caso_o_nome_ja_esteja_cadastrado() //cenário 3
        {
            //arrange
            repositorioGrupoAutomovelMoq.Setup(x => x.SelecionarPorNome("Desconto do Deko"))
                 .Returns(() => {
                     return new GrupoAutomovel("Desconto do Deko");
                 });

            GrupoAutomovel novoGrupo = new GrupoAutomovel("Desconto do Deko");

            //action
            var resultado = servicoGrupoAutomovel.Editar(novoGrupo);

            //assert 
            resultado.Should().BeFailure();

            repositorioGrupoAutomovelMoq.Verify(x => x.Editar(novoGrupo), Times.Never());
        }

        [TestMethod]
        public void Deve_tratar_erro_caso_ocorra_falha_ao_tentar_editar_grupo() //cenário 4
        {
            repositorioGrupoAutomovelMoq.Setup(x => x.Editar(It.IsAny<GrupoAutomovel>()))
                .Throws(() => {
                    return new Exception();
                });

            //action
            Result resultado = servicoGrupoAutomovel.Editar(grupo);

            //assert 
            resultado.Should().BeFailure();
            resultado.Errors[0].Message.Should().Be("Falha ao tentar editar grupo.");
        }

        [TestMethod]
        public void Deve_excluir_parceiro_caso_ele_esteja_cadastrado() //cenário 1
        {
            //arrange
            var parceiro = new GrupoAutomovel("Desconto do Deko");

            repositorioGrupoAutomovelMoq.Setup(x => x.Existe(grupo))
               .Returns(() => {
                   return true;
               });

            //action
            var resultado = servicoGrupoAutomovel.Excluir(grupo);

            //assert 
            resultado.Should().BeSuccess();
            repositorioGrupoAutomovelMoq.Verify(x => x.Excluir(grupo), Times.Once());
        }

        [TestMethod]
        public void Nao_deve_excluir_parceiro_caso_ele_nao_esteja_cadastrado() //cenário 2
        {
            //arrange

            var parceiro = new GrupoAutomovel("Desconto do Deko");

            repositorioGrupoAutomovelMoq.Setup(x => x.Existe(grupo))
               .Returns(() => {
                   return false;
               });

            //action
            var resultado = servicoGrupoAutomovel.Excluir(grupo);

            //assert 
            resultado.Should().BeFailure();
            repositorioGrupoAutomovelMoq.Verify(x => x.Excluir(grupo), Times.Never());
        }
    }
}
