using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloTaxaServico;
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloAluguel {
    public partial class TabelaAluguelControl : UserControl {
        public TabelaAluguelControl() {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }
        public DataGridViewColumn[] ObterColunas() {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", FillWeight=15F, Visible = false},

                new DataGridViewTextBoxColumn { Name = "Condutor", HeaderText = "Nome do Condutor", FillWeight=15F },

                new DataGridViewTextBoxColumn { Name = "Automovel", HeaderText = "Automóvel", FillWeight=15F },

                new DataGridViewTextBoxColumn { Name = "Plano", HeaderText = "Plano de Cobrança", FillWeight=15F },

                new DataGridViewTextBoxColumn { Name = "DataSaida", HeaderText = "Data de Saída", FillWeight=15F },

                new DataGridViewTextBoxColumn { Name = "DataPrevista", HeaderText = "Data de Devolução Prevista", FillWeight=15F },

                new DataGridViewTextBoxColumn { Name = "ValorTotal", HeaderText = "Valor Total", FillWeight=15F },

                new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Status", FillWeight=15F }
            };

            return colunas;
        }

        public Guid ObtemIdSelecionado() {
            return grid.SelecionarId();
        }

        public void AtualizarRegistros(List<Aluguel> alugueis) {
            grid.Rows.Clear();

            foreach (Aluguel a in alugueis) {
                string status = VerificarStatus(a);
                grid.Rows.Add(a.Id, a.Condutor, a.Automovel, a.PlanoCobranca, a.DataLocacao.ToShortDateString(), a.DataDevolucaoPrevista.ToShortDateString(), a.ValorTotal,status);
            }
        }

        private string VerificarStatus(Aluguel aluguel) {
            string status;
            if (aluguel.Encerrado == true) status = "Encerrado";
            else status = "Em aberto";

            return status;
        }
    }
}
