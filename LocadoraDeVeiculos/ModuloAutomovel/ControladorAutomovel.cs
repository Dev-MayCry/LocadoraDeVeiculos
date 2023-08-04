using FluentResults;
using LocadoraDeVeiculos.Aplicacao.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloAutomovel {
    public class ControladorAutomovel : ControladorBase{

        private IRepositorioAutomovel repositorioAutomovel;
        private TabelaAutomovelControl tabelaAutomovel;
        private ServicoAutomovel servicoAutomovel;
        private IRepositorioGrupoAutomovel repositorioGrupoAutomovel;

        public ControladorAutomovel(IRepositorioAutomovel repositorioAutomovel, ServicoAutomovel servicoAutomovel, IRepositorioGrupoAutomovel repositorioGrupoAutomovel) {
            this.repositorioAutomovel = repositorioAutomovel;
            this.servicoAutomovel = servicoAutomovel;
            this.repositorioGrupoAutomovel = repositorioGrupoAutomovel;
        }

        public override void Inserir() {
            TelaAutomovelForm tela = new TelaAutomovelForm(repositorioGrupoAutomovel);

            tela.onGravarRegistro += servicoAutomovel.Inserir;

            tela.ConfigurarAutomovel(new Automovel());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarAutomoveis();
            }
        }

        public override void Editar() {
            Guid id = tabelaAutomovel.ObtemIdSelecionado();

            Automovel automovelSelecionado = repositorioAutomovel.SelecionarPorId(id);

            if (automovelSelecionado == null) {
                MessageBox.Show("Selecione um automóvel primeiro",
                "Edição de Automóveis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaAutomovelForm tela = new(repositorioGrupoAutomovel);

            tela.onGravarRegistro += servicoAutomovel.Editar;

            tela.ConfigurarAutomovel(automovelSelecionado);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarAutomoveis();
            }
        }

        public override void Excluir() {
            Guid id = tabelaAutomovel.ObtemIdSelecionado();

            Automovel automovelSelecionado = repositorioAutomovel.SelecionarPorId(id);

            if (automovelSelecionado == null) {
                MessageBox.Show("Selecione um automóvel primeiro",
                "Exclusão de Automóveis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show("Deseja realmente excluir o automóvel?",
               "Exclusão de Automóveis", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK) {
                Result resultado = servicoAutomovel.Excluir(automovelSelecionado);

                if (resultado.IsFailed) {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Automóveis",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                CarregarAutomoveis();
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox() {
            return new ConfigurarToolBoxAutomovel();
        }

        public override UserControl ObtemListagem() {
            if (tabelaAutomovel == null)
                tabelaAutomovel = new TabelaAutomovelControl();

            CarregarAutomoveis();

            return tabelaAutomovel;
        }

        private void CarregarAutomoveis() {
            List<Automovel> automovel = repositorioAutomovel.SelecionarTodos();

            tabelaAutomovel.AtualizarRegistros(automovel);

            mensagemRodape = string.Format($"Visualizando {automovel.Count} automóve{0}", automovel.Count == 1 ? "l" : "is");

            TelaPrincipalForm.Instancia.AtualizarRodape(mensagemRodape);
        }
    }
}
