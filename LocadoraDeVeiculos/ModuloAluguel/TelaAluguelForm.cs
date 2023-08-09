using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloAluguel {
    public partial class TelaAluguelForm : Form {

        Aluguel aluguel;

        public event GravarRegistroDelegate<Aluguel> onGravarRegistro;

        public TelaAluguelForm() {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Aluguel ObterAlugel() {



            return aluguel;
        }

        public void ConfigurarAluguel(Aluguel aluguel) {
            this.aluguel = aluguel;
            if (aluguel == null) {

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            aluguel = ObterAlugel();

            Result resultado = onGravarRegistro(aluguel);

            if (resultado.IsFailed) {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void txtKmAutomovel_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}
