using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloGrupoAutomovel {
    public partial class TelaGrupoAutomovelForm : Form {

        private GrupoAutomovel grupoAutomovel;

        public event GravarRegistroDelegate<GrupoAutomovel> onGravarRegistro;

        public TelaGrupoAutomovelForm() {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public GrupoAutomovel ObterGrupo() {
            grupoAutomovel.Id = Convert.ToInt32(txtId.Text);
            grupoAutomovel.Nome = txtNome.Text;

            return grupoAutomovel;
        }

        public void ConfigurarGrupo(GrupoAutomovel grupoAutomovel) {
            this.grupoAutomovel = grupoAutomovel;

            txtId.Text = grupoAutomovel.Id.ToString();
            txtNome.Text = grupoAutomovel.Nome;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            grupoAutomovel = ObterGrupo();

            Result resultado = onGravarRegistro(grupoAutomovel);

            if (resultado.IsFailed) {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
