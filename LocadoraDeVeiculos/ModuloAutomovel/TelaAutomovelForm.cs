using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloAutomovel {
    public partial class TelaAutomovelForm : Form {

        private Automovel automovel;

        public event GravarRegistroDelegate<Automovel> onGravarRegistro;

        public TelaAutomovelForm() {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Automovel ObterAutomovel() {

            automovel.Ano = txtAno.Value;
            automovel.Placa = txtPlaca.Text;
            automovel.Modelo = txtModelo.Text;
            automovel.Marca = txtMarca.Text;
            automovel.Cor = txtCor.Text;
            automovel.CapacidadeLitros = Convert.ToInt32(txtCapacidadeLitros.Text);
            automovel.TipoCombustivel = (TipoCombustivelEnum)txtListaTipoCombustivel.SelectedItem;
            automovel.GrupoAutomovel = (GrupoAutomovel)txtListaGrupoAutomoveis.SelectedItem;

            byte[] byteArray;
            if (fotoCarro.Image != null) {
                try {
                    byteArray = File.ReadAllBytes(fotoCarro.ImageLocation);
                    automovel.Foto = byteArray;

                } catch (Exception ex) {
                    MessageBox.Show("Erro vagabundo, não salvou a imagem, código tá errado");
                }
            }

            return automovel;
        }

        public void ConfigurarAutomovel(Automovel automovel) {

            this.automovel = automovel;
            txtAno.Value = automovel.Ano;
            txtPlaca.Text = automovel.Placa;
            txtModelo.Text = automovel.Modelo;
            txtMarca.Text = automovel.Marca;
            txtCor.Text = automovel.Cor;
            txtCapacidadeLitros.Text = automovel.CapacidadeLitros.ToString();
            txtListaTipoCombustivel.SelectedItem = automovel.TipoCombustivel;
            txtListaGrupoAutomoveis.SelectedItem = automovel.GrupoAutomovel;

        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            automovel = ObterAutomovel();

            Result resultado = onGravarRegistro(automovel);

            if (resultado.IsFailed) {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}