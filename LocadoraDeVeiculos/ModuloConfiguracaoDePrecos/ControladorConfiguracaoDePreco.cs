using FluentResults;
using LocadoraDeVeiculos.Aplicacao.ModuloConfiguracaoDePrecos;
using LocadoraDeVeiculos.Aplicacao.ModuloCupom;
using LocadoraDeVeiculos.Dominio.ModuloConfiguracaoDePrecos;
using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.WinApp.Compartilhado;
using LocadoraDeVeiculos.WinApp.ModuloCupom;
using LocadoraDeVeiculos.WinApp.ModuloPlanoCobranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WinApp.ModuloConfiguracaoDePrecos {
    public class ControladorConfiguracaoDePreco:ControladorBase {

        private IRepositorioConfiguracaoPreco repositorioConfiguracaoDePreco;
        
        private TabelaConfigurador tabelaConfigurador;
        private ServicoConfiguracaodePreco servicoConfigurador;
        public ControladorConfiguracaoDePreco(IRepositorioConfiguracaoPreco repositorioConfiguracaoDePreco, ServicoConfiguracaodePreco servicoConfigurador) {
            this.repositorioConfiguracaoDePreco = repositorioConfiguracaoDePreco;
            this.servicoConfigurador = servicoConfigurador;
        }

        public override void Excluir() {
            Guid id = tabelaConfigurador.ObtemIdSelecionado();

            ConfiguracaoDePreco configurador = repositorioConfiguracaoDePreco.SelecionarPorId(id);

            if (configurador == null) {
                MessageBox.Show("Selecione um configurador primeiro",
                "Exclusão de configurador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show("Deseja realmente excluir o configurador?",
               "Exclusão de Cupons", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //if (opcaoEscolhida == DialogResult.OK) {
            //    //Result resultado = servicoConfigurador.Excluir(configurador);

            //    if (resultado.IsFailed) {
            //        MessageBox.Show(resultado.Errors[0].Message, "Exclusão de configurador",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);

            //        return;
            //    }

            //    CarregarCupom();
            //}
        }

        private void CarregarConfigurador() {
            List<ConfiguracaoDePreco> configurador = repositorioConfiguracaoDePreco.SelecionarTodos();

            tabelaConfigurador.AtualizarRegistros(configurador);

            mensagemRodape = string.Format("Visualizando {0} configurador{1}", configurador.Count, configurador.Count == 1 ? "" : "s");

            TelaPrincipalForm.Instancia.AtualizarRodape(mensagemRodape);
        }

        public override void Inserir() {
            TelaConfiguracaoPrecos tela = new TelaConfiguracaoPrecos(repositorioConfiguracaoDePreco.SelecionarTodos());

            tela.onGravarRegistro += servicoConfigurador.Inserir;

            tela.ConfigurarPrecos(new ConfiguracaoDePreco());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarConfigurador();
            }
        }
        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox() {
            return new ConfigurarToolBoxCupom();
        }

        public override UserControl ObtemListagem() {
            if (tabelaConfigurador == null)
                tabelaConfigurador = new TabelaConfigurador();

            CarregarConfigurador();

            return tabelaConfigurador;

        }

        public override void Editar() {
            Guid id = tabelaConfigurador.ObtemIdSelecionado();

            ConfiguracaoDePreco configurador = repositorioConfiguracaoDePreco.SelecionarPorId(id);

            if (configurador == null) {
                MessageBox.Show("Selecione um Configurador primeiro",
                "Configuração de Preços", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaConfiguracaoPrecos tela = new TelaConfiguracaoPrecos(repositorioConfiguracaoDePreco.SelecionarTodos());

            tela.onGravarRegistro += servicoConfigurador.Editar;

            tela.ConfigurarPrecos(configurador);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarConfigurador();
            }
        }
    }
}
