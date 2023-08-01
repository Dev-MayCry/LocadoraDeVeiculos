using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloFuncionario {
    public partial class TabelaFuncionarioControl : UserControl {
        public TabelaFuncionarioControl() {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas() {

            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", FillWeight=15F, Visible = false },

                new DataGridViewTextBoxColumn { Name = "Nome", HeaderText = "Nome", FillWeight=60F },

                new DataGridViewTextBoxColumn { Name = "Data de Admissão", HeaderText = "Data de Admissão", FillWeight=20F },

                new DataGridViewTextBoxColumn { Name = "Salário", HeaderText = "Salário", FillWeight=20F }
            };
            return colunas;
        }

        public Guid ObtemIdSelecionado() {
            return grid.SelecionarId();
        }

        public void AtualizarRegistros(List<Funcionario> funcionarios) {
            grid.Rows.Clear();

            foreach (Funcionario f in funcionarios ) {
                grid.Rows.Add(f.Id,f.Nome,f.DataAdmissao.ToShortDateString(),$"R$: {f.Salario}");
            }
        }
    }
}
