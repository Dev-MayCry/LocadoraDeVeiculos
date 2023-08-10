using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using LocadoraDeVeiculos.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WinApp.ModuloPlanoCobranca {
    public partial class TabelaPlanoCobrancaControl : UserControl {
        public TabelaPlanoCobrancaControl() {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas() {

            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", FillWeight=15F, Visible = false },

                new DataGridViewTextBoxColumn { Name = "Grupo de Automóveis", HeaderText = "Grupo de Automóveis", FillWeight=60F },

                new DataGridViewTextBoxColumn { Name = "Tipo do Plano", HeaderText = "Tipo do Plano", FillWeight=20F },

                new DataGridViewTextBoxColumn { Name = "Preço Diária", HeaderText = "Preço Diária", FillWeight=20F },

                new DataGridViewTextBoxColumn { Name = "Preço por Km", HeaderText = "Preço por Km", FillWeight=20F },

                new DataGridViewTextBoxColumn { Name = "Km Disponíveis", HeaderText = "Km Disponíveis", FillWeight=20F }
            };
            return colunas;
        }

        public Guid ObtemIdSelecionado() {
            return grid.SelecionarId();
        }

        public void AtualizarRegistros(List<PlanoCobranca> planosCobrancas) {
            grid.Rows.Clear();

            foreach (PlanoCobranca p in planosCobrancas) {
                if (p.tipo == TipoPlanoEnum.PlanoLivre) {
                    grid.Rows.Add(p.Id, p.grupo, "Plano Livre", $"R$: {p.PrecoDiaria}", "-","-");
                }
                else if (p.tipo == TipoPlanoEnum.PlanoDiario) {
                    grid.Rows.Add(p.Id, p.grupo, "Plano Controlador", $"R$: {p.PrecoDiaria}", $"R$: {p.PrecoKm}", "-");
                }
                else
                grid.Rows.Add(p.Id, p.grupo, p.tipo, $"R$: {p.PrecoDiaria}", $"R$: {p.PrecoKm}", $"R$: {p.KmDisponiveis}");
            }
        }

        
    }
}
