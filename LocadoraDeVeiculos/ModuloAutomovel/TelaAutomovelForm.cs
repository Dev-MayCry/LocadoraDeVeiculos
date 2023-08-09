using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloAutomovel {
    public partial class TelaAutomovelForm : Form {

        private Automovel automovel;

        public event GravarRegistroDelegate<Automovel> onGravarRegistro;

        public TelaAutomovelForm(IRepositorioGrupoAutomovel repositorioGrupoAutomovel) {
            InitializeComponent();
            this.ConfigurarDialog();
            ConfigurarComboBox(repositorioGrupoAutomovel);
        }

        private void ConfigurarComboBox(IRepositorioGrupoAutomovel repositorioGrupoAutomovel) {
            foreach (var item in repositorioGrupoAutomovel.SelecionarTodos())
                txtListaGrupoAutomoveis.Items.Add(item);
            txtListaGrupoAutomoveis.SelectedIndex = 0;

            txtListaTipoCombustivel.Items.Add(TipoCombustivelEnum.Alcool);
            txtListaTipoCombustivel.Items.Add(TipoCombustivelEnum.Diesel);
            txtListaTipoCombustivel.Items.Add(TipoCombustivelEnum.Gas);
            txtListaTipoCombustivel.Items.Add(TipoCombustivelEnum.Gasolina);
            txtListaTipoCombustivel.SelectedIndex = 0;

            txtCapacidadeLitros.Text = "0";
            txtQuilometragem.Text = "0";
        }

        public Automovel ObterAutomovel() {

            automovel.Ano = (int)txtAno.Value;
            automovel.Placa = txtPlaca.Text;
            automovel.Modelo = txtModelo.Text;
            automovel.Marca = txtMarca.Text;
            automovel.Cor = txtCor.Text;
            automovel.CapacidadeLitros = Convert.ToInt32(txtCapacidadeLitros.Text);
            automovel.Quilometragem = Convert.ToInt32(txtQuilometragem.Text);
            automovel.TipoCombustivel = (TipoCombustivelEnum)txtListaTipoCombustivel.SelectedItem;
            automovel.GrupoAutomovel = (GrupoAutomovel)txtListaGrupoAutomoveis.SelectedItem;

            byte[] foto = null;
            foto = ConverterImagemEmByteArray(foto);
            automovel.Foto = foto;

            return automovel;
        }

        public void ConfigurarAutomovel(Automovel automovel) {

            this.automovel = automovel;
            if (automovel.Placa != null) {
                txtAno.Value = automovel.Ano;
                txtPlaca.Text = automovel.Placa;
                txtModelo.Text = automovel.Modelo;
                txtMarca.Text = automovel.Marca;
                txtCor.Text = automovel.Cor;
                txtCapacidadeLitros.Text = automovel.CapacidadeLitros.ToString();
                txtQuilometragem.Text = automovel.Quilometragem.ToString();
                txtListaTipoCombustivel.SelectedItem = automovel.TipoCombustivel;
                txtListaGrupoAutomoveis.SelectedItem = automovel.GrupoAutomovel;

                Image foto = null;
                foto = ConverterByteArrayEmImagem(automovel, foto);
                fotoAutomovel.Image = foto;
            }

        }

        private byte[] ConverterImagemEmByteArray(byte[] foto) {
            try {
                // Cria um MemoryStream para armazenar os bytes da imagem
                using (MemoryStream ms = new MemoryStream()) {
                    // Salva a imagem no MemoryStream no formato JPEG (ou outro formato de sua escolha)
                    fotoAutomovel.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                    // Obtém os bytes da imagem a partir do MemoryStream
                    foto = ms.ToArray();
                }
            } catch (Exception ex) {
                Console.WriteLine($"Erro ao converter a imagem em byte array: {ex.Message}");
            }

            return foto;
        }

        private static Image ConverterByteArrayEmImagem(Automovel automovel, Image foto) {
            try {
                // Cria um MemoryStream a partir do array de bytes
                using (MemoryStream ms = new MemoryStream(automovel.Foto)) {
                    // Cria a imagem a partir do MemoryStream
                    foto = Image.FromStream(ms);
                }
            } catch (Exception ex) {
                Console.WriteLine($"Erro ao converter o byte array em imagem: {ex.Message}");
            }

            return foto;
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

        private void btnBuscar_Click(object sender, EventArgs e) {
            // Configurações do OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem |*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Selecione uma imagem";

            // Exibe o OpenFileDialog e verifica se o usuário clicou em "OK"
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                // Obtém o caminho do arquivo selecionado pelo usuário
                string caminhoDaImagem = openFileDialog.FileName;

                // Carrega a imagem do arquivo selecionado
                Image imagem = Image.FromFile(caminhoDaImagem);

                // Exibe a imagem no PictureBox
                fotoAutomovel.Image = imagem;
            }

        }

        private void btnApagar_Click(object sender, EventArgs e) {
            fotoAutomovel.Image = null;
        }

        private void txtCapacidadeLitros_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtQuilometragem_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtQuilometragem_TextChanged(object sender, EventArgs e) {
            if (txtQuilometragem.Text.Length < 1)
                txtQuilometragem.Text = "0";
        }

        private void txtCapacidadeLitros_TextChanged(object sender, EventArgs e) {
            if (txtCapacidadeLitros.Text.Length < 1)
                txtCapacidadeLitros.Text = "0";
        }
    }
}