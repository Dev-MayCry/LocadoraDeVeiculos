using LocadoraDeVeiculos.Dominio.ModuloTaxaServico;
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloTaxaServico {
    public partial class TabelaTaxaServicoControl : UserControl {
        public TabelaTaxaServicoControl() {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }
        public DataGridViewColumn[] ObterColunas() {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", FillWeight=15F, Visible = false},

                new DataGridViewTextBoxColumn { Name = "Nome", HeaderText = "Nome", FillWeight=15F },

                new DataGridViewTextBoxColumn { Name = "Preço", HeaderText = "Preço", FillWeight=15F },
            };

            return colunas;
        }

        public Guid ObtemIdSelecionado() {
            return grid.SelecionarId();
        }

        public void AtualizarRegistros(List<TaxaServico> taxas) {
            grid.Rows.Clear();

            foreach (TaxaServico t in taxas) {
                grid.Rows.Add(t.Id, t.Nome, t.Preco);
            }
        }
    }
}
