using FluentAssertions;
using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.WinApp.Compartilhado;
using System.Drawing;

namespace LocadoraDeVeiculos.WinApp.ModuloCupom
{
    public partial class TelaCupomForm : Form
    {
        private Cupom cupom;
        public event GravarRegistroDelegate<Cupom> onGravarRegistro;
        public TelaCupomForm(List<Parceiro> parceiros)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            CarregarParceiros(parceiros);

        }
        public Cupom ObterCupom()
        {
            cupom.Nome = txtNome.Text;
            cupom.Parceiro = (Parceiro)txtListaParceiro.SelectedItem;
            cupom.Valor = Convert.ToInt32(txtValor.Text);
            cupom.DataValidade = Convert.ToDateTime(dataValidade.Value);
            return cupom;
        }

        public void ConfigurarCupom(Cupom cupom)
        {           
            this.cupom = cupom;
            txtNome.Text = cupom.Nome;
            txtListaParceiro.SelectedItem = cupom.Parceiro;
            txtValor.Text = cupom.Valor.ToString("0.00");
            dataValidade.Value = cupom.DataValidade;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.cupom = ObterCupom();

            Result resultado = onGravarRegistro(cupom);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
        private void CarregarParceiros(List<Parceiro> parceiros)
        {
            txtListaParceiro.Items.Clear();

            foreach (var item in parceiros)
            {
                txtListaParceiro.Items.Add(item);
            }
        }
    }
}
