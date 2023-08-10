using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloCondutor {
    public partial class TelaCondutorForm : Form {

        Condutor condutor;

        public event GravarRegistroDelegate<Condutor> onGravarRegistro;

        public TelaCondutorForm(List<Cliente> clientes) {
            InitializeComponent();
            this.ConfigurarDialog();
            ConfigurarComboBox(clientes);
        }

        private void ConfigurarComboBox(List<Cliente> clientes) {
            txtListaClientes.Items.Clear();
            foreach (Cliente item in clientes)
                txtListaClientes.Items.Add(item);
            txtListaClientes.SelectedIndex = 0;
        }

        public Condutor ObterCondutor() {
            condutor.Cliente = (Cliente)txtListaClientes.SelectedItem;
            condutor.Nome = txtNome.Text;
            condutor.Email = txtEmail.Text;
            condutor.Telefone = txtTelefone.Text;
            condutor.Cpf = txtCpf.Text;
            condutor.Cnh = txtCnh.Text;
            condutor.DataValidade = txtData.Value;
            return condutor;
        }

        public void ConfigurarCondutor(Condutor condutor) {
            this.condutor = condutor;
        }

        public void ConfigurarCondutorEdicao(Condutor condutor) {
            this.condutor = condutor;
            txtListaClientes.SelectedItem = condutor.Cliente;
            txtNome.Text = condutor.Nome;
            txtEmail.Text = condutor.Email;
            txtTelefone.Text = condutor.Telefone;
            txtCpf.Text = condutor.Cpf;
            txtCnh.Text = condutor.Cnh;
            txtData.Value = condutor.DataValidade;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            condutor = ObterCondutor();

            Result resultado = onGravarRegistro(condutor);

            if (resultado.IsFailed) {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void btnCliente_CheckedChanged(object sender, EventArgs e) {
            if (btnCliente.Checked) {
                Cliente cliente = (Cliente)txtListaClientes.SelectedItem;
                if (cliente.TipoCliente == TipoClienteEnum.Fisica) {
                    txtNome.Text = cliente.Nome;
                    txtEmail.Text = cliente.Email;
                    txtTelefone.Text = cliente.Telefone;
                    txtCpf.Text = cliente.Cpf;
                    AlteraTextBoxs(true);
                } else {
                    btnCliente.Checked = false;
                    MessageBox.Show("Esse Cliente é jurídico e não pode ser condutor!", "Cadastro de Condutores");
                    AlteraTextBoxs(false);
                }
            } else {
                btnCliente.Checked = false;
                txtNome.Text = "";
                txtEmail.Text = "";
                txtTelefone.Text = "";
                txtCpf.Text = "";
                AlteraTextBoxs(false);
            }
        }

        private void AlteraTextBoxs(bool boolean) {
            txtNome.ReadOnly = boolean;
            txtEmail.ReadOnly = boolean;
            txtTelefone.ReadOnly = boolean;
            txtCpf.ReadOnly = boolean;

        }

        private void txtListaClientes_SelectedIndexChanged(object sender, EventArgs e) {
            if (btnCliente.Checked) {
                btnCliente.Checked = false;
            }
        }
    }
}
