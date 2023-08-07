using FizzWare.NBuilder;
using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using LocadoraDeVeiculos.TestesIntegracao.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.TestesIntegracao.ModuloPlanoCobranca {

    [TestClass]
    public class RepositorioPlanoCobrancaOrm: TesteIntegracaoBase {


        [TestMethod]
        public void Deve_inserir_Plano() {
            //arrange
            var grupoAutomovel = Builder<GrupoAutomovel>.CreateNew().Persist();
            var plano = Builder<PlanoCobranca>.CreateNew().With(x => x.grupo = grupoAutomovel).Build();

            //action
            repositorioPlanoCobranca.Inserir(plano);

            //assert
            repositorioPlanoCobranca.SelecionarPorId(plano.Id).Should().Be(plano);
        }

        [TestMethod]
        public void Deve_editar_plano() {
            //arrange
            var grupoAutomovel = Builder<GrupoAutomovel>.CreateNew().Persist();
            var plano = Builder<PlanoCobranca>.CreateNew().With(x => x.grupo = grupoAutomovel).Persist();

            plano.PrecoDiaria = 34;

            //action
            repositorioPlanoCobranca.Editar(plano);

            //assert
            repositorioPlanoCobranca.SelecionarPorId(plano.Id).Should().Be(plano);
        }

        [TestMethod]
        public void Deve_excluir_plano() {
            //arrange
            var grupoAutomovel = Builder<GrupoAutomovel>.CreateNew().Persist();
            var plano = Builder<PlanoCobranca>.CreateNew().With(x => x.grupo = grupoAutomovel).Persist();

            //action
            repositorioPlanoCobranca.Excluir(plano);

            //assert
            repositorioPlanoCobranca.SelecionarPorId(plano.Id).Should().BeNull();
        }

        [TestMethod]
        public void Deve_selecionar_todas_parceiros() {
            //arrange
            var grupoAutomovel = Builder<GrupoAutomovel>.CreateNew().Persist();
            var plano = Builder<PlanoCobranca>.CreateNew().With(x => x.grupo = grupoAutomovel).Persist();
            var plano2 = Builder<PlanoCobranca>.CreateNew().With(x => x.grupo = grupoAutomovel).Persist();

            //action
            var planos = repositorioPlanoCobranca.SelecionarTodos();

            //assert
            planos.Should().ContainInOrder(plano, plano2);
            planos.Should().HaveCount(2);
        }


        [TestMethod]
        public void Deve_selecionar_plano_por_id() {
            //arrange
            var grupoAutomovel = Builder<GrupoAutomovel>.CreateNew().Persist();
            var plano = Builder<PlanoCobranca>.CreateNew().With(x => x.grupo = grupoAutomovel).Persist();

            //action
            var parceirosEncontrado = repositorioPlanoCobranca.SelecionarPorId(plano.Id);

            //assert            
            parceirosEncontrado.Should().Be(plano);
        }

    }
}
