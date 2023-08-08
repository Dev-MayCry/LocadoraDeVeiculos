using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloCondutor {
    public partial class TabelaCondutorControl : UserControl {
        public TabelaCondutorControl() {
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

                new DataGridViewTextBoxColumn { Name = "Cliente", HeaderText = "Cliente", FillWeight=15F },

                new DataGridViewTextBoxColumn { Name = "Cpf", HeaderText = "Cpf", FillWeight=15F },

                new DataGridViewTextBoxColumn { Name = "Cnh", HeaderText = "Cnh", FillWeight=15F },
                
                new DataGridViewTextBoxColumn { Name = "Data de Validade", HeaderText = "Data de Validade", FillWeight=15F }
            };

            return colunas;
        }

        public Guid ObtemIdSelecionado() {
            return grid.SelecionarId();
        }

        public void AtualizarRegistros(List<Condutor> condutores) {
            grid.Rows.Clear();

            foreach (Condutor c in condutores) {
                grid.Rows.Add(c.Id, c.Nome, c.Cliente.Nome, c.Cpf, c.Cnh, c.DataValidade.ToString());
            }
        }
    }
}
