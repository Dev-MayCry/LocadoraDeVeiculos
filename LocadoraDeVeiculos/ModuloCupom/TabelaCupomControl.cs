using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.WinApp.Compartilhado;
namespace LocadoraDeVeiculos.WinApp.ModuloCupom
{
    public partial class TabelaCupomControl : UserControl
    {
        public TabelaCupomControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", FillWeight=15F },

                new DataGridViewTextBoxColumn { Name = "Nome", HeaderText = "Nome", FillWeight=45F },

                new DataGridViewTextBoxColumn { Name = "Parceiro", HeaderText = "Parceiro", FillWeight=25F },

                new DataGridViewTextBoxColumn { Name = "Valor", HeaderText = "Valor", FillWeight=25F },

                 new DataGridViewTextBoxColumn { Name = "Data de Validade", HeaderText = "Data de Validade", FillWeight=25F }
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return grid.SelecionarId();
        }

        public void AtualizarRegistros(List<Cupom> cupons)
        {
            grid.Rows.Clear();

            foreach (Cupom cupom in cupons)
            {
                grid.Rows.Add(cupom.Id, cupom.Nome,cupom.Parceiro,cupom.Valor,cupom.DataValidade);
            }
        }
    }
}
