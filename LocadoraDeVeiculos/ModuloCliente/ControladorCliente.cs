
using FluentResults;
using LocadoraDeVeiculos.Aplicacao.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.WinApp.Compartilhado;
using LocadoraDeVeiculos.WinApp.ModuloFuncionario;
namespace LocadoraDeVeiculos.WinApp.ModuloCliente
{
    internal class ControladorCliente : ControladorBase
    {     
        private IRepositorioCliente repositorioCliente;
        private TabelaClienteControl tabelaCliente;
        private ServicoCliente servicoCliente;
        public ControladorCliente(IRepositorioCliente repositorioCliente, ServicoCliente servicoCliente)
        {
            this.repositorioCliente = repositorioCliente;
            this.servicoCliente = servicoCliente;
        }
        public override void Inserir()
        {
            TelaClienteForm tela = new TelaClienteForm(repositorioCliente.SelecionarTodos());

            tela.onGravarRegistro += servicoCliente.Inserir;

            tela.ConfigurarCliente(new Cliente());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarClientes();
            }
        }
        public override void Editar()
        {
            Guid id = tabelaCliente.ObtemIdSelecionado();

            Cliente clienteSelecionada = repositorioCliente.SelecionarPorId(id);

            if (clienteSelecionada == null)
            {
                MessageBox.Show("Selecione uma cliente primeiro",
                "Edição de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaClienteForm tela = new TelaClienteForm(repositorioCliente.SelecionarTodos());

            tela.onGravarRegistro += servicoCliente.Editar;

            tela.ConfigurarCliente(clienteSelecionada);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarClientes();
            }
        }
        public override void Excluir()
        {
            Guid id = tabelaCliente.ObtemIdSelecionado();

            Cliente clienteSelecionada = repositorioCliente.SelecionarPorId(id);

            if (clienteSelecionada == null)
            {
                MessageBox.Show("Selecione um cliente primeiro",
                "Exclusão de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult opcaoEscolhida = MessageBox.Show("Deseja realmente excluir o cliente ?",
               "Exclusão de Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoCliente.Excluir(clienteSelecionada);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Clientes",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                CarregarClientes();
            }
        }
        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfigurarToolBoxCliente();
        }
        public override UserControl ObtemListagem()
        {
            if (tabelaCliente == null)
                tabelaCliente = new TabelaClienteControl();

            CarregarClientes();

            return tabelaCliente;
        }
        private void CarregarClientes()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();

            tabelaCliente.AtualizarRegistros(clientes);

            mensagemRodape = string.Format("Visualizando {0} Clientes{1}", clientes.Count, clientes.Count == 1 ? "" : "s");

            TelaPrincipalForm.Instancia.AtualizarRodape(mensagemRodape);
        }
    }

}
