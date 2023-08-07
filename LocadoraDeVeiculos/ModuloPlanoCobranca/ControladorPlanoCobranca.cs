using FluentResults;
using LocadoraDeVeiculos.Aplicacao.ModuloPlanoCobranca;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloPlanoCobranca {
    public class ControladorPlanoCobranca : ControladorBase {

        private IRepositorioPlanoCobranca repositorioPlanoCobranca;
        private IRepositorioGrupoAutomovel repositorioGrupoAutomovel;
        private TabelaPlanoCobrancaControl tabelaPlanoCobranca;
        private ServicoPlanoCobranca servicoPlanoCobranca;
        public ControladorPlanoCobranca(IRepositorioPlanoCobranca repositorioPlanoCobranca, ServicoPlanoCobranca servicoPlanoCobranca,IRepositorioGrupoAutomovel repositorioGrupoAutomovel) {
            this.repositorioPlanoCobranca = repositorioPlanoCobranca;
            this.servicoPlanoCobranca = servicoPlanoCobranca;
            this.repositorioGrupoAutomovel = repositorioGrupoAutomovel;


        }
        public override void Inserir() {
            TelaPlanoCobrancaForm tela = new TelaPlanoCobrancaForm(repositorioGrupoAutomovel.SelecionarTodos(),repositorioPlanoCobranca);

            tela.onGravarRegistro += servicoPlanoCobranca.Inserir;

            tela.ConfigurarPlanoCobranca(new PlanoCobranca());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarPlanoCobrancas();
            }
        }

        public override void Editar() {
            Guid id = tabelaPlanoCobranca.ObtemIdSelecionado();

            PlanoCobranca planoCobrancaSelecionada = repositorioPlanoCobranca.SelecionarPorId(id);

            if (planoCobrancaSelecionada == null) {
                MessageBox.Show("Selecione um plano de cobrança primeiro",
                "Edição de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaPlanoCobrancaForm tela = new TelaPlanoCobrancaForm(repositorioGrupoAutomovel.SelecionarTodos());

            tela.onGravarRegistro += servicoPlanoCobranca.Editar;

            tela.ConfigurarPlanoCobrancaEdicao(planoCobrancaSelecionada);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarPlanoCobrancas();
            }
        }

        public override void Excluir() {
            Guid id = tabelaPlanoCobranca.ObtemIdSelecionado();

            PlanoCobranca planoCobrancaSelecionada = repositorioPlanoCobranca.SelecionarPorId(id);

            if (planoCobrancaSelecionada == null) {
                MessageBox.Show("Selecione uma planoCobranca primeiro",
                "Exclusão de Plano de Cobranças", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show("Deseja realmente excluir a planoCobranca?",
               "Exclusão de Plano de Cobranças", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK) {
                Result resultado = servicoPlanoCobranca.Excluir(planoCobrancaSelecionada);

                if (resultado.IsFailed) {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de PlanoCobrancas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                CarregarPlanoCobrancas();
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox() {
            return new ConfigurarToolBoxPlanoCobranca();
        }

        public override UserControl ObtemListagem() {
            if (tabelaPlanoCobranca == null)
                tabelaPlanoCobranca = new TabelaPlanoCobrancaControl();

            CarregarPlanoCobrancas();

            return tabelaPlanoCobranca;
        }

        private void CarregarPlanoCobrancas() {
            List<PlanoCobranca> planoCobrancas = repositorioPlanoCobranca.SelecionarTodos();

            tabelaPlanoCobranca.AtualizarRegistros(planoCobrancas);

            mensagemRodape = string.Format("Visualizando {0} plano{1} de cobrança.", planoCobrancas.Count, planoCobrancas.Count == 1 ? "" : "s");

            TelaPrincipalForm.Instancia.AtualizarRodape(mensagemRodape);
        }
    }
}
