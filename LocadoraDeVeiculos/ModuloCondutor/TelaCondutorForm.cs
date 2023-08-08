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
            if(condutor == null) {
                txtListaClientes.SelectedItem = condutor.Cliente;
                txtNome.Text = condutor.Nome;
                txtEmail.Text = condutor.Email;
                txtTelefone.Text = condutor.Telefone;
                txtCpf.Text = condutor.Cpf;
                txtCnh.Text = condutor.Cnh;
                txtData.Value = condutor.DataValidade;
            }
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
    }
}
