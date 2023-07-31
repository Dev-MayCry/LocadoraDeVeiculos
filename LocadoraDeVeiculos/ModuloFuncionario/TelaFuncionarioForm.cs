using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.WinApp.Compartilhado;


namespace LocadoraDeVeiculos.WinApp.ModuloFuncionario {
    public partial class TelaFuncionarioForm : Form {

        private Funcionario funcionario;

        public event GravarRegistroDelegate<Funcionario> onGravarRegistro;
        public TelaFuncionarioForm() {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Funcionario ObterFuncionario() {
            funcionario.Id = Convert.ToInt32(txtId.Text);
            funcionario.Nome = txtNome.Text;
            funcionario.DataAdmissao = Convert.ToDateTime(dtpDataAdmissao.Text);
            funcionario.Salario = Convert.ToDouble(txtSalario.Text);

            return funcionario;
        }

        public void ConfigurarFuncionario(Funcionario funcionario) {
            this.funcionario = funcionario;
            funcionario.DataAdmissao = DateTime.Now;
            txtId.Text = funcionario.Id.ToString();
            txtNome.Text = funcionario.Nome;
            txtSalario.Text = funcionario.Salario.ToString();
            dtpDataAdmissao.Text = funcionario.DataAdmissao.ToShortDateString();
        }

        private void btnGravar_Click(object sender, EventArgs e) {
            this.funcionario = ObterFuncionario();

            Result resultado = onGravarRegistro(funcionario);

            if (resultado.IsFailed) {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
