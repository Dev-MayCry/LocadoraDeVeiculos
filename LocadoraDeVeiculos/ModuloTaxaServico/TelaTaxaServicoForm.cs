using LocadoraDeVeiculos.Dominio.ModuloTaxaServico;
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloTaxaServico {
    public partial class TelaTaxaServicoForm : Form {

        private TaxaServico taxaServico;

        private GravarRegistroDelegate<TaxaServico> onGravarRegistro;

        public TelaTaxaServicoForm() {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        private void textPreco_TextChanged(object sender, EventArgs e) {

        }
    }
}
