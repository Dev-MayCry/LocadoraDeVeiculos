using LocadoraDeVeiculos.Aplicacao.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using FluentResults;
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloAluguel {
    public class ControladorAluguel : ControladorBase{
        IRepositorioAluguel repositorioAluguel;
        TabelaAluguelControl tabelaAluguel;
        ServicoAluguel servicoAluguel;

        public ControladorAluguel(IRepositorioAluguel repositorioAluguel, ServicoAluguel servicoAluguel) {
            this.repositorioAluguel = repositorioAluguel;
            this.servicoAluguel = servicoAluguel;
        }

        public override void Inserir() {
            TelaAluguelForm tela = new();

            tela.onGravarRegistro += servicoAluguel.Inserir;

            tela.ConfigurarAluguel(new Aluguel());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarAlugueis();
            }
        }

        public override void Editar() {
            Guid id = tabelaAluguel.ObtemIdSelecionado();

            Aluguel aluguelSelecionada = repositorioAluguel.SelecionarPorId(id);

            if (aluguelSelecionada == null) {
                MessageBox.Show("Selecione um aluguel primeiro",
                "Edição de Aluguéis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaAluguelForm tela = new();

            tela.onGravarRegistro += servicoAluguel.Editar;

            tela.ConfigurarAluguel(aluguelSelecionada);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarAlugueis();
            }
        }

        public override void Excluir() {
            Guid id = tabelaAluguel.ObtemIdSelecionado();

            Aluguel aluguelSelecionada = repositorioAluguel.SelecionarPorId(id);

            if (aluguelSelecionada == null) {
                MessageBox.Show("Selecione uma aluguel primeiro",
                "Exclusão de Aluguéis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show("Deseja realmente excluir o aluguel?",
               "Exclusão de Aluguéis", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK) {
                Result resultado = servicoAluguel.Excluir(aluguelSelecionada);

                if (resultado.IsFailed) {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Aluguéis",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                CarregarAlugueis();
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox() {
            return new ConfigurarToolBoxAluguel();
        }

        public override UserControl ObtemListagem() {
            if (tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();
            CarregarAlugueis();

            return tabelaAluguel;
        }

        private void CarregarAlugueis() {
            List<Aluguel> alugueis = repositorioAluguel.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(alugueis);

            mensagemRodape = string.Format("Visualizando {0} alugue{1}", alugueis.Count, alugueis.Count == 1 ? "l" : "éis");

            TelaPrincipalForm.Instancia.AtualizarRodape(mensagemRodape);
        }
    }
}
