using FluentResults;
using LocadoraDeVeiculos.Aplicacao.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Aplicacao.ModuloTaxaServico;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloTaxaServico;
using LocadoraDeVeiculos.WinApp.Compartilhado;
using LocadoraDeVeiculos.WinApp.ModuloGrupoAutomovel;

namespace LocadoraDeVeiculos.WinApp.ModuloTaxaServico {
    public class ControladorTaxaServico : ControladorBase{

        IRepositorioTaxaServico repositorioTaxaServico;
        TabelaTaxaServicoControl tabelaTaxaServico;
        ServicoTaxaServico servicoTaxaServico;

        public ControladorTaxaServico(IRepositorioTaxaServico repositorioTaxaServico, ServicoTaxaServico servicoTaxaServico) {
            this.repositorioTaxaServico = repositorioTaxaServico;
            this.servicoTaxaServico = servicoTaxaServico;
        }

        public override void Inserir() {
            TelaTaxaServicoForm tela = new TelaTaxaServicoForm();

            tela.onGravarRegistro += servicoTaxaServico.Inserir;

            tela.ConfigurarTaxa(new TaxaServico());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarTaxas();
            }
        }

        public override void Editar() {
            Guid id = tabelaTaxaServico.ObtemIdSelecionado();

            TaxaServico taxaSelecionada = repositorioTaxaServico.SelecionarPorId(id);

            if (taxaSelecionada == null) {
                MessageBox.Show("Selecione uma taxa primeiro",
                "Edição de Taxa de Serviços", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaTaxaServicoForm tela = new();

            tela.onGravarRegistro += servicoTaxaServico.Editar;

            tela.ConfigurarTaxa(taxaSelecionada);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarTaxas();
            }
        }

        public override void Excluir() {
            Guid id = tabelaTaxaServico.ObtemIdSelecionado();

            TaxaServico taxaSelecionada = repositorioTaxaServico.SelecionarPorId(id);

            if (taxaSelecionada == null) {
                MessageBox.Show("Selecione uma taxa primeiro",
                "Exclusão de Taxa de Serviços", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show("Deseja realmente excluir a taxa?",
               "Exclusão de Taxa de Serviços", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK) {
                Result resultado = servicoTaxaServico.Excluir(taxaSelecionada);

                if (resultado.IsFailed) {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Taxa de Serviços",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                CarregarTaxas();
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox() {
            return new ConfigurarToolBoxTaxaServico();
        }

        public override UserControl ObtemListagem() {
            if (tabelaTaxaServico == null)
                tabelaTaxaServico = new TabelaTaxaServicoControl();

            CarregarTaxas();

            return tabelaTaxaServico;
        }

        private void CarregarTaxas() {
            List<TaxaServico> taxas = repositorioTaxaServico.SelecionarTodos();

            tabelaTaxaServico.AtualizarRegistros(taxas);

            mensagemRodape = string.Format($"Visualizando {taxas.Count} taxa{0}", taxas.Count == 1 ? "" : "s");

            TelaPrincipalForm.Instancia.AtualizarRodape(mensagemRodape);
        }
    }
}
