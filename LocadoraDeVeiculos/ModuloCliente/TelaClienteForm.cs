using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.WinApp.Compartilhado;


namespace LocadoraDeVeiculos.WinApp.ModuloCliente {
    public partial class TelaClienteForm : Form {
        private Cliente cliente;
        public event GravarRegistroDelegate<Cliente> onGravarRegistro;
        public TelaClienteForm(List<Cliente> clientes) {
            InitializeComponent();
            this.ConfigurarDialog();
            btnFisica.Checked = true;
        }
        public Cliente ObterCliente() {
            cliente.Rua = txtRua.Text;
            cliente.Nome = txtNome.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Cnpj = txtCnpj.Text;
            cliente.NumeroDaCasa = txtNumeroDaCasa.Text;
            cliente.Email = txtEmail.Text;
            cliente.Estado = txtEstado.Text;
            cliente.Bairro = TxtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            if (btnJuridica.Checked)
                cliente.TipoCliente = TipoClienteEnum.Juridica;
            else cliente.TipoCliente = TipoClienteEnum.Fisica;

            return cliente;
        }
        public void ConfigurarCliente(Cliente cliente) {
            this.cliente = cliente;
            txtNome.Text = cliente.Nome;
            txtEstado.Text = cliente.Estado;
            txtTelefone.Text = cliente.Telefone;
            txtCpf.Text = cliente.Cpf;
            txtCnpj.Text = cliente.Cnpj;
            txtNumeroDaCasa.Text = cliente.NumeroDaCasa;
            txtEmail.Text = cliente.Email;
            txtRua.Text = cliente.Rua;
            txtCidade.Text = cliente.Cidade;
            TxtBairro.Text = cliente.Bairro;

            if (cliente.TipoCliente == TipoClienteEnum.Juridica) {
                btnJuridica.Checked = true;
                btnFisica.Checked = false;
            } else {
                btnJuridica.Checked = false;
                btnFisica.Checked = true;
            }




        }
        private void btnGravar_Click(object sender, EventArgs e) {
            this.cliente = ObterCliente();

            Result resultado = onGravarRegistro(cliente);

            if (resultado.IsFailed) {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void btnJuridica_CheckedChanged(object sender, EventArgs e) {
            if (btnJuridica.Checked == true) {
                txtCpf.Enabled = false;
                txtCnpj.Enabled = true;
            }

        }

        private void btnFisica_CheckedChanged(object sender, EventArgs e) {
            if (btnFisica.Checked == true) {
                txtCpf.Enabled = true;
                txtCnpj.Enabled = false;
            }
        }
    }
}
