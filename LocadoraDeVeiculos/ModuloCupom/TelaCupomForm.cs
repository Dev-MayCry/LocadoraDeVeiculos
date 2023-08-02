using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.WinApp.Compartilhado;
using LocadoraDeVeiculos.WinApp.ModuloParceiro;
using System.Drawing.Drawing2D;

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
            cupom.Id = Convert.ToInt32(txtId.Text);
            cupom.Nome = txtNome.Text;
            cupom.Parceiro = (Parceiro)txtListaParceiro.SelectedItem;
            cupom.Valor = Convert.ToInt32(txtValor.Text);
            cupom.DataValidade = Convert.ToDateTime(dataValidade.Value);


            return cupom;
        }

        public void ConfigurarCupom(Cupom cupom)
        {
            this.cupom = cupom;

            txtId.Text = cupom.Id.ToString();
            txtNome.Text = cupom.Nome;
            txtListaParceiro.SelectedItem = cupom.Parceiro;
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
