using FluentResults;
using LocadoraDeVeiculos.Aplicacao.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.WinApp.Compartilhado;
using LocadoraDeVeiculos.WinApp.ModuloFuncionario;


namespace LocadoraDeVeiculos.WinApp.ModuloFuncionario {
    public class ControladorFuncionario : ControladorBase {

        private IRepositorioFuncionario repositorioFuncionario;
        private TabelaFuncionarioControl tabelaFuncionario;
        private ServicoFuncionario servicoFuncionario;
        public ControladorFuncionario(IRepositorioFuncionario repositorioFuncionario, ServicoFuncionario servicoFuncionario) {
            this.repositorioFuncionario = repositorioFuncionario;
            this.servicoFuncionario = servicoFuncionario;


        }
        public override void Inserir() {
            TelaFuncionarioForm tela = new TelaFuncionarioForm();

            tela.onGravarRegistro += servicoFuncionario.Inserir;

            tela.ConfigurarFuncionario(new Funcionario());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarFuncionarios();
            }
        }

        public override void Editar() {
            Guid id = tabelaFuncionario.ObtemIdSelecionado();

            Funcionario funcionarioSelecionada = repositorioFuncionario.SelecionarPorId(id);

            if (funcionarioSelecionada == null) {
                MessageBox.Show("Selecione uma funcionario primeiro",
                "Edição de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaFuncionarioForm tela = new TelaFuncionarioForm();

            tela.onGravarRegistro += servicoFuncionario.Editar;

            tela.ConfigurarFuncionario(funcionarioSelecionada);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarFuncionarios();
            }
        }

        public override void Excluir() {
            Guid id = tabelaFuncionario.ObtemIdSelecionado();

            Funcionario funcionarioSelecionada = repositorioFuncionario.SelecionarPorId(id);

            if (funcionarioSelecionada == null) {
                MessageBox.Show("Selecione uma funcionario primeiro",
                "Exclusão de Funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show("Deseja realmente excluir a funcionario?",
               "Exclusão de Funcionarios", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK) {
                Result resultado = servicoFuncionario.Excluir(funcionarioSelecionada);

                if (resultado.IsFailed) {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Funcionarios",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                CarregarFuncionarios();
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox() {
            return new ConfigurarToolBoxFuncionario();
        }

        public override UserControl ObtemListagem() {
            if (tabelaFuncionario == null)
                tabelaFuncionario = new TabelaFuncionarioControl();

            CarregarFuncionarios();

            return tabelaFuncionario;
        }

        private void CarregarFuncionarios() {
            List<Funcionario> funcionarios = repositorioFuncionario.SelecionarTodos();

            tabelaFuncionario.AtualizarRegistros(funcionarios);

            mensagemRodape = string.Format("Visualizando {0} funcionario{1}", funcionarios.Count, funcionarios.Count == 1 ? "" : "s");

            TelaPrincipalForm.Instancia.AtualizarRodape(mensagemRodape);
        }
    }
}
