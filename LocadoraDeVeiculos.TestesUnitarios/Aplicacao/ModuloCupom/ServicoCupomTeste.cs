using FluentAssertions;
using FluentResults;
using Moq;
using FluentResults.Extensions.FluentAssertions;
using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Aplicacao.ModuloCupom;

namespace LocadoraDeVeiculos.TestesUnitarios.Aplicacao.ModuloCupom
{
    [TestClass]
    public class ServicoCupomTeste
    {

        Mock<IRepositorioCupom> repositorioCupomMoq;
        Mock<IValidadorCupom> validadorMoq;

        private ServicoCupom servicoCupom;

        Cupom cupom;

        public ServicoCupomTeste()
        {
            repositorioCupomMoq = new Mock<IRepositorioCupom>();
            validadorMoq = new Mock<IValidadorCupom>();
            servicoCupom = new ServicoCupom(repositorioCupomMoq.Object, validadorMoq.Object);
            cupom = new Cupom("Desconto do Deko");
        }

        [TestMethod]
        public void Deve_inserir_cupom_caso_ela_for_valido() //cenário 1
        {
            //arrange
            cupom = new Cupom("Desconto do Deko");

            //action
            Result resultado = servicoCupom.Inserir(cupom);

            //assert 
            resultado.Should().BeSuccess();
            repositorioCupomMoq.Verify(x => x.Inserir(cupom), Times.Once());
        }

        [TestMethod]
        public void Nao_deve_inserir_cupom_caso_o_nome_ja_esteja_cadastrado() //cenário 3
        {
            //arrange
            string nomeCupom = "Desconto do Deko";
            repositorioCupomMoq.Setup(x => x.SelecionarPorNome(nomeCupom))
                .Returns(() => {
                    return new Cupom(nomeCupom);
                });

            //action
            var resultado = servicoCupom.Inserir(cupom);

            //assert 
            resultado.Should().BeFailure();
            resultado.Reasons[0].Message.Should().Be($"Este nome '{nomeCupom}' já está sendo utilizado");
            repositorioCupomMoq.Verify(x => x.Inserir(cupom), Times.Never());
        }

        [TestMethod]
        public void Deve_tratar_erro_caso_ocorra_falha_ao_tentar_inserir_cupom() //cenário 4
        {
            repositorioCupomMoq.Setup(x => x.Inserir(It.IsAny<Cupom>()))
                .Throws(() => {
                    return new Exception();
                });

            //action
            Result resultado = servicoCupom.Inserir(cupom);

            //assert 
            resultado.Should().BeFailure();
            resultado.Reasons[0].Message.Should().Be("Falha ao tentar inserir cupom.");
        }

        [TestMethod]
        public void Deve_editar_cupom_caso_ele_for_valido() //cenário 1
        {
            //arrange           
            cupom = new Cupom("iFood");

            //action
            Result resultado = servicoCupom.Editar(cupom);

            //assert 
            resultado.Should().BeSuccess();
            repositorioCupomMoq.Verify(x => x.Editar(cupom), Times.Once());
        }

        [TestMethod]
        public void Deve_editar_cupom_com_o_mesmo_nome() //cenário 3
        {
            //arrange
            Guid id = new Guid();
            repositorioCupomMoq.Setup(x => x.SelecionarPorNome("Desconto do Deko"))
                 .Returns(() => {
                     return new Cupom(id, "Desconto do Deko");
                 });

           Cupom outroCupom = new Cupom(id, "Desconto do Deko");

            //action
            var resultado = servicoCupom.Editar(outroCupom);

            //assert 
            resultado.Should().BeSuccess();

            repositorioCupomMoq.Verify(x => x.Editar(outroCupom), Times.Once());
        }

        [TestMethod]
        public void Nao_deve_editar_cupom_caso_o_nome_ja_esteja_cadastrado() //cenário 4
        {
            //arrange
            repositorioCupomMoq.Setup(x => x.SelecionarPorNome("Desconto do Deko"))
                 .Returns(() => {
                     return new Cupom("Desconto do Deko");
                 });

            Cupom novoCupom = new Cupom("Desconto do Deko");

            //action
            var resultado = servicoCupom.Editar(novoCupom);

            //assert 
            resultado.Should().BeFailure();

            repositorioCupomMoq.Verify(x => x.Editar(novoCupom), Times.Never());
        }

        [TestMethod]
        public void Deve_tratar_erro_caso_ocorra_falha_ao_tentar_editar_cupom() //cenário 5
        {
            repositorioCupomMoq.Setup(x => x.Editar(It.IsAny<Cupom>()))
                .Throws(() => {
                    return new Exception();
                });

            //action
            Result resultado = servicoCupom.Editar(cupom);

            //assert 
            resultado.Should().BeFailure();
            resultado.Errors[0].Message.Should().Be("Falha ao tentar editar cupom.");
        }

        [TestMethod]
        public void Deve_excluir_cupom_caso_ele_esteja_cadastrado() //cenário 1
        {
            //arrange
            var cupom = new Cupom("Desconto do Deko");

            repositorioCupomMoq.Setup(x => x.Existe(cupom))
               .Returns(() => {
                   return true;
               });

            //action
            var resultado = servicoCupom.Excluir(cupom);

            //assert 
            resultado.Should().BeSuccess();
            repositorioCupomMoq.Verify(x => x.Excluir(cupom), Times.Once());
        }

        [TestMethod]
        public void Nao_deve_excluir_parceiro_caso_ele_nao_esteja_cadastrado() //cenário 2
        {
            //arrange

            var cupom = new Cupom("Desconto do Deko");

            repositorioCupomMoq.Setup(x => x.Existe(cupom))
               .Returns(() => {
                   return false;
               });

            //action
            var resultado = servicoCupom.Excluir(cupom);

            //assert 
            resultado.Should().BeFailure();
            repositorioCupomMoq.Verify(x => x.Excluir(cupom), Times.Never());
        }


    }

}

