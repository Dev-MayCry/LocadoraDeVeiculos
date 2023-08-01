﻿using FluentResults;
using LocadoraDeVeiculos.Aplicacao.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloGrupoAutomovel {
    internal class ControladorGrupoAutomovel : ControladorBase {

        private IRepositorioGrupoAutomovel repositorioGrupoAutomovel;
        private TabelaGrupoAutomovelControl tabelaGrupoAutomovel;
        private ServicoGrupoAutomovel servicoGrupoAutomovel;

        public ControladorGrupoAutomovel(IRepositorioGrupoAutomovel repositorioGrupoAutomovel, ServicoGrupoAutomovel servicoGrupoAutomovel) {
            this.repositorioGrupoAutomovel = repositorioGrupoAutomovel;
            this.servicoGrupoAutomovel = servicoGrupoAutomovel;
        }

        public override void Inserir() {
            TelaGrupoAutomovelForm tela = new TelaGrupoAutomovelForm();

            tela.onGravarRegistro += servicoGrupoAutomovel.Inserir;

            tela.ConfigurarGrupo(new GrupoAutomovel());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarGrupos();
            }
        }

        public override void Editar() {
            int id = tabelaGrupoAutomovel.ObtemIdSelecionado();

            GrupoAutomovel grupoAutomovelSelecionado = repositorioGrupoAutomovel.SelecionarPorId(id);

            if (grupoAutomovelSelecionado == null) {
                MessageBox.Show("Selecione um grupo primeiro",
                "Edição de Grupo de Automóveis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaGrupoAutomovelForm tela = new();

            tela.onGravarRegistro += servicoGrupoAutomovel.Editar;

            tela.ConfigurarGrupo(grupoAutomovelSelecionado);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarGrupos();
            }
        }

        public override void Excluir() {
            int id = tabelaGrupoAutomovel.ObtemIdSelecionado();

            GrupoAutomovel grupoAutomovelSelecionado = repositorioGrupoAutomovel.SelecionarPorId(id);

            if (grupoAutomovelSelecionado == null) {
                MessageBox.Show("Selecione um grupo primeiro",
                "Exclusão de Grupo de Automóveis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show("Deseja realmente excluir o grupo?",
               "Exclusão de Grupo de Automóveis", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK) {
                Result resultado = servicoGrupoAutomovel.Excluir(grupoAutomovelSelecionado);

                if (resultado.IsFailed) {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Grupo de Automóveis",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                CarregarGrupos();
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox() {
            return new ConfigurarToolBoxGrupoAutomovel();
        }

        public override UserControl ObtemListagem() {
            if (tabelaGrupoAutomovel == null)
                tabelaGrupoAutomovel = new TabelaGrupoAutomovelControl();

            CarregarGrupos();

            return tabelaGrupoAutomovel;
        }

        private void CarregarGrupos() {
            List<GrupoAutomovel> grupoAutomovel = repositorioGrupoAutomovel.SelecionarTodos();

            tabelaGrupoAutomovel.AtualizarRegistros(grupoAutomovel);

            mensagemRodape = string.Format($"Visualizando {grupoAutomovel.Count} parceiro{0}", grupoAutomovel.Count == 1 ? "" : "s");

            TelaPrincipalForm.Instancia.AtualizarRodape(mensagemRodape);
        }
    }
}
