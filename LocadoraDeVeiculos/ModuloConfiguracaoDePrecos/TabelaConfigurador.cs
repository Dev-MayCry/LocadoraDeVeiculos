using LocadoraDeVeiculos.Dominio.ModuloConfiguracaoDePrecos;
using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloPlanoCobranca {
    public partial class TabelaConfigurador : UserControl {
        public TabelaConfigurador() {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas() {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", FillWeight=15F, Visible = false },

                new DataGridViewTextBoxColumn { Name = "Combustível", HeaderText = "Combustível", FillWeight=45F },

                new DataGridViewTextBoxColumn { Name = "Valor", HeaderText = "Valor", FillWeight=25F },

            };

            return colunas;
        }

        public Guid ObtemIdSelecionado() {
            return grid.SelecionarId();
        }
        public void AtualizarRegistros(List<ConfiguracaoDePreco> configurador) {

            grid.Rows.Clear();

            
            grid.Rows.Add("Álcool","R$"+ configurador[0].PrecoAlcool);
            grid.Rows.Add("Diesel","R$"+ configurador[0].PrecoDiesel);
            grid.Rows.Add("Gás","R$"+ configurador[0].PrecoGas);
            grid.Rows.Add("Gasolina","R$"+ configurador[0].PrecoGasolina);
            
        }
    }
}
