using FluentResults;
using LocadoraDeVeiculos.Aplicacao.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloCondutor {
    public class ControladorCondutor : ControladorBase{
        IRepositorioCondutor repositorioCondutor;
        TabelaCondutorControl tabelaCondutor;
        ServicoCondutor servicoCondutor;
        IRepositorioCliente repositorioCliente;

        public ControladorCondutor(IRepositorioCondutor repositorioCondutor, ServicoCondutor servicoCondutor, IRepositorioCliente repositorioCliente) {
            this.repositorioCondutor = repositorioCondutor;
            this.servicoCondutor = servicoCondutor;
            this.repositorioCliente = repositorioCliente;
        }

        public override void Inserir() {
            if (VerificarCliente()) return;
            TelaCondutorForm tela = new(repositorioCliente.SelecionarTodos());

            tela.onGravarRegistro += servicoCondutor.Inserir;

            tela.ConfigurarCondutor(new Condutor());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarCondutores();
            }
        }

        public override void Editar() {
            Guid id = tabelaCondutor.ObtemIdSelecionado();

            Condutor condutorSelecionada = repositorioCondutor.SelecionarPorId(id);

            if (condutorSelecionada == null) {
                MessageBox.Show("Selecione um condutor primeiro",
                "Edição de Condutores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCondutorForm tela = new(repositorioCliente.SelecionarTodos());

            tela.onGravarRegistro += servicoCondutor.Editar;

            tela.ConfigurarCondutorEdicao(condutorSelecionada);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarCondutores();
            }
        }

        public override void Excluir() {
            Guid id = tabelaCondutor.ObtemIdSelecionado();

            Condutor condutorSelecionada = repositorioCondutor.SelecionarPorId(id);

            if (condutorSelecionada == null) {
                MessageBox.Show("Selecione uma condutor primeiro",
                "Exclusão de Condutores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show("Deseja realmente excluir o condutor?",
               "Exclusão de Condutores", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK) {
                Result resultado = servicoCondutor.Excluir(condutorSelecionada);

                if (resultado.IsFailed) {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Condutores",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                CarregarCondutores();
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox() {
            return new ConfigurarToolBoxCondutor();
        }

        public override UserControl ObtemListagem() {
            if (tabelaCondutor == null)
                tabelaCondutor = new TabelaCondutorControl();

            CarregarCondutores();

            return tabelaCondutor;
        }

        private void CarregarCondutores() {
            List<Condutor> condutors = repositorioCondutor.SelecionarTodos();

            tabelaCondutor.AtualizarRegistros(condutors);

            mensagemRodape = string.Format("Visualizando {0} condutor{1}", condutors.Count, condutors.Count == 1 ? "" : "es");

            TelaPrincipalForm.Instancia.AtualizarRodape(mensagemRodape);
        }

        private bool VerificarCliente() {
            if (repositorioCliente.SelecionarTodos().Count() == 0) {
                MessageBox.Show($"Nenhum Cliente cadastrado", "Novo Condutor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            } else return false;
        }

        
    }
}
