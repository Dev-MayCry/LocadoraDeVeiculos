using FluentResults;
using LocadoraDeVeiculos.Aplicacao.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
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

            if (VerificarGrupo()) return;

            TelaAutomovelForm tela = new TelaAutomovelForm(repositorioGrupoAutomovel);

            tela.onGravarRegistro += servicoAutomovel.Inserir;

            tela.ConfigurarAutomovel(new Automovel());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarAutomoveis();
            }
        }

        public override void Filtrar() {
            TelaFiltroAutomovelForm tela = new(repositorioGrupoAutomovel);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                List<Automovel> automoveis = repositorioAutomovel.SelecionarPorGrupo(tela.grupo);

                CarregarAutomoveis(automoveis);

            } else if(resultado == DialogResult.Abort) {
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
            List<Automovel> automoveis = repositorioAutomovel.SelecionarTodos();

            tabelaAutomovel.AtualizarRegistros(automoveis);

            mensagemRodape = string.Format("Visualizando {0} automóve{1}", automoveis.Count, automoveis.Count == 1 ? "l" : "is");

            TelaPrincipalForm.Instancia.AtualizarRodape(mensagemRodape);
        }

        private void CarregarAutomoveis(List<Automovel> automoveis) {
            tabelaAutomovel.AtualizarRegistros(automoveis);

            mensagemRodape = string.Format("Visualizando {0} automóve{1}", automoveis.Count, automoveis.Count == 1 ? "l" : "is");

            TelaPrincipalForm.Instancia.AtualizarRodape(mensagemRodape);
        }

        private bool VerificarGrupo() {
            if (repositorioGrupoAutomovel.SelecionarTodos().Count() == 0) {
                MessageBox.Show($"Nenhum Grupo de Automóvel cadastrado", "Novo Automóvel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            } else return false;
        }
    }
}
