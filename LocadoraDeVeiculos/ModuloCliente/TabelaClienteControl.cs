using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.WinApp.Compartilhado;
namespace LocadoraDeVeiculos.WinApp.ModuloCliente
{
    public partial class TabelaClienteControl : UserControl
    {
        public TabelaClienteControl()
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
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", FillWeight=15F, Visible = false },
        
                new DataGridViewTextBoxColumn { Name = "Nome ", HeaderText = "Nome ", FillWeight=25F },

                new DataGridViewTextBoxColumn { Name = "Email ", HeaderText = "Email ", FillWeight=25F },

                new DataGridViewTextBoxColumn { Name = "Telefone ", HeaderText = "Telefone ", FillWeight=20F },

                new DataGridViewTextBoxColumn { Name = "CPF/CNPJ ", HeaderText = "CPF/CNPJ ", FillWeight=20F },              
              
                new DataGridViewTextBoxColumn { Name = "Tipo do CLiente ", HeaderText = "Tipo do Cliente ", FillWeight=20F },
            };
            return colunas;
        }
        public Guid ObtemIdSelecionado()
        {
            return grid.SelecionarId();
        }
        public void AtualizarRegistros(List<Cliente> clientes)
        {
            grid.Rows.Clear();

            foreach (Cliente c in clientes)
            {
                string documento = VerificarDocumento(c);
                grid.Rows.Add(c.Id, c.Nome, c.Email,c.Telefone, documento,c.TipoCliente);
            }
        }

        private string VerificarDocumento(Cliente c) {
            if (c.TipoCliente == TipoClienteEnum.Fisica) return c.Cpf;
            else return c.Cnpj;
        }
    }
}

