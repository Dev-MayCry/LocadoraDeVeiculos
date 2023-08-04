using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloAutomovel {
    public partial class TabelaAutomovelControl : UserControl {
        public TabelaAutomovelControl() {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }
        public DataGridViewColumn[] ObterColunas() {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", FillWeight=15F, Visible = false},

                new DataGridViewTextBoxColumn { Name = "Placa", HeaderText = "Placa", FillWeight=15F },

                new DataGridViewTextBoxColumn { Name = "Marca", HeaderText = "Marca", FillWeight=15F },

                new DataGridViewTextBoxColumn { Name = "Cor", HeaderText = "Cor", FillWeight=15F },

                new DataGridViewTextBoxColumn { Name = "Modelo", HeaderText = "Modelo", FillWeight=15F },

                new DataGridViewTextBoxColumn { Name = "TipoDeCombustivel", HeaderText = "Tipo de Combustível", FillWeight=15F },

                new DataGridViewTextBoxColumn { Name = "GrupoDeAutomovel", HeaderText = "Grupo de Automóvel", FillWeight=15F }

            };

            return colunas;
        }

        public Guid ObtemIdSelecionado() {
            return grid.SelecionarId();
        }

        public void AtualizarRegistros(List<Automovel> automoveis) {
            grid.Rows.Clear();

            foreach (Automovel a in automoveis) {
                grid.Rows.Add(a.Id, a.Placa, a.Marca, a.Cor, a.Modelo, a.TipoCombustivel, a.GrupoAutomovel);
            }
        }
    }
}
