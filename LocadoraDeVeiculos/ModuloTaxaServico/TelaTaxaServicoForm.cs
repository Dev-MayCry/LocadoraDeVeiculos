using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloTaxaServico;
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloTaxaServico {
    public partial class TelaTaxaServicoForm : Form {

        private TaxaServico taxaServico;

        public GravarRegistroDelegate<TaxaServico> onGravarRegistro;

        public TelaTaxaServicoForm() {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public TaxaServico ObterTaxa() {
            taxaServico.Nome = txtNome.Text;
            taxaServico.Preco = Convert.ToDecimal(txtPreco.Text);
            if (btnPrecoFixo.Enabled) taxaServico.TipoPlano = TipoPlanoCalculoEnum.PrecoFixo;
            else taxaServico.TipoPlano = TipoPlanoCalculoEnum.CobrancaDiaria;
            return taxaServico;
        }

        public void ConfigurarTaxa(TaxaServico taxaServico) {
            txtNome.Text = taxaServico.Nome;
            txtPreco.Text = taxaServico.Preco.ToString();
            if (taxaServico.TipoPlano == TipoPlanoCalculoEnum.PrecoFixo) btnPrecoFixo.Checked = true;
            else btnPrecoFixo.Checked = false;
        }

        private void textPreco_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            taxaServico = ObterTaxa();

            Result resultado = onGravarRegistro(taxaServico);

            if (resultado.IsFailed) {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
