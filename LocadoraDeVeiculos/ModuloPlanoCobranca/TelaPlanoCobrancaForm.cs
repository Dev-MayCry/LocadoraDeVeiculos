using FluentResults;
using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using LocadoraDeVeiculos.WinApp.Compartilhado;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WinApp.ModuloPlanoCobranca {
    public partial class TelaPlanoCobrancaForm : Form {

        private PlanoCobranca planoCobranca;
        private IRepositorioPlanoCobranca repositorioPlanoCobranca;

        public event GravarRegistroDelegate<PlanoCobranca> onGravarRegistro;
        public TelaPlanoCobrancaForm(List<GrupoAutomovel> grupos,IRepositorioPlanoCobranca repositorioPlanoCobranca) {
            this.repositorioPlanoCobranca = repositorioPlanoCobranca;
            
            InitializeComponent();
            this.ConfigurarDialog();
            CarregarGrupos(grupos);
            //CarregarTipos(grupo);
        }

        public TelaPlanoCobrancaForm(List<GrupoAutomovel> grupos) {
            

            InitializeComponent();
            this.ConfigurarDialog();
           
        }

        public PlanoCobranca ObterPlanoCobranca() {

            planoCobranca.grupo = (GrupoAutomovel)cmbGrupoAutomoveis.SelectedItem;
            planoCobranca.tipo = (TipoPlanoEnum)cmbNomesPlanos.SelectedItem;
            planoCobranca.PrecoDiaria = Convert.ToDecimal(txtPrecoDiaria.Text);

            if(planoCobranca.tipo == TipoPlanoEnum.PlanoDiario) {
                planoCobranca.PrecoKm = Convert.ToDecimal(txtPrecoKm.Text);
                planoCobranca.KmDisponiveis = 0;
            }
            if(planoCobranca.tipo == TipoPlanoEnum.PlanoControlador) {
                planoCobranca.PrecoKm = Convert.ToDecimal(txtPrecoKm.Text);
                planoCobranca.KmDisponiveis = Convert.ToInt32(txtKmDisponiveis.Text);
            }
            if (planoCobranca.tipo == TipoPlanoEnum.PlanoLivre) {
                planoCobranca.PrecoKm = 0;
                planoCobranca.KmDisponiveis = 0;

            }

            return planoCobranca;
        }

        public void ConfigurarPlanoCobranca(PlanoCobranca planoCobranca) {

            this.planoCobranca = planoCobranca;


            cmbGrupoAutomoveis.SelectedItem = planoCobranca.grupo;
            cmbNomesPlanos.SelectedItem = planoCobranca.tipo;
            txtPrecoDiaria.Text = "";
            txtPrecoKm.Text = "";
            txtKmDisponiveis.Text = "";
        }

        public void ConfigurarPlanoCobrancaEdicao(PlanoCobranca planoCobranca) {

            this.planoCobranca = planoCobranca;
            ConfigurarCmbEdicao(planoCobranca);
            
            txtPrecoDiaria.Text = planoCobranca.PrecoDiaria.ToString();
            txtPrecoKm.Text = planoCobranca.PrecoKm.ToString();
            txtKmDisponiveis.Text = planoCobranca.KmDisponiveis.ToString();
        }


        private GrupoAutomovel CarregarGrupos(List<GrupoAutomovel> grupos) {

            cmbGrupoAutomoveis.Items.Clear();
            GrupoAutomovel grupo;
            foreach (var g in grupos) {

                List<PlanoCobranca> listaPlanos = repositorioPlanoCobranca.SelecionarPorGrupo(g);
                if (listaPlanos.Count < 3) {
                    cmbGrupoAutomoveis.Items.Add(g);
                }

            }

            if (cmbGrupoAutomoveis.Items.Count > 0) {
                cmbGrupoAutomoveis.SelectedItem = cmbGrupoAutomoveis.Items[0];
                
            }

            return (GrupoAutomovel)cmbGrupoAutomoveis.SelectedItem;



        }

        private void CarregarTipos(GrupoAutomovel grupo) {

            cmbNomesPlanos.Items.Clear();


            if (!grupo.PossuiPlanoDiario) cmbNomesPlanos.Items.Add(TipoPlanoEnum.PlanoDiario);
            if (!grupo.PossuiPlanoControlador) cmbNomesPlanos.Items.Add(TipoPlanoEnum.PlanoControlador);
            if (!grupo.PossuiPlanoLivre) cmbNomesPlanos.Items.Add(TipoPlanoEnum.PlanoLivre);

            if (cmbNomesPlanos.Items.Count > 0) {
                cmbNomesPlanos.SelectedItem = cmbNomesPlanos.Items[0];
            }

        }

        private void ConfigurarCmbEdicao(PlanoCobranca planoCobranca) {

            cmbGrupoAutomoveis.Items.Add(planoCobranca.grupo);
            cmbGrupoAutomoveis.SelectedItem = cmbGrupoAutomoveis.Items[0];
            cmbGrupoAutomoveis.Enabled = false;
            cmbNomesPlanos.Items.Clear();
            cmbNomesPlanos.Items.Add(planoCobranca.tipo);
            cmbNomesPlanos.SelectedItem = cmbNomesPlanos.Items[0];
            cmbNomesPlanos.Enabled = false;

            var tipo = planoCobranca.tipo;

            if (tipo == TipoPlanoEnum.PlanoDiario) {
                txtPrecoKm.Enabled = true;
                txtKmDisponiveis.Enabled = false;

            } else if (tipo == TipoPlanoEnum.PlanoLivre) {
                txtPrecoKm.Enabled = false;
                txtKmDisponiveis.Enabled = false;

            } else if (tipo == TipoPlanoEnum.PlanoControlador) {
                txtPrecoKm.Enabled = true;
                txtKmDisponiveis.Enabled = true;
            }

        }

      

        private void btnGravar_Click(object sender, EventArgs e) {
            this.planoCobranca = ObterPlanoCobranca();

            Result resultado = onGravarRegistro(planoCobranca);

            if (resultado.IsFailed) {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void cmbNomesPlanos_SelectedIndexChanged(object sender, EventArgs e) {

                var tipo = (TipoPlanoEnum)cmbNomesPlanos.SelectedItem;

                if (tipo == TipoPlanoEnum.PlanoDiario) {
                    txtPrecoKm.Enabled = true;
                    txtKmDisponiveis.Enabled = false;

                } else if (tipo == TipoPlanoEnum.PlanoLivre) {
                    txtPrecoKm.Enabled = false;
                    txtKmDisponiveis.Enabled = false;

                } else if (tipo == TipoPlanoEnum.PlanoControlador) {
                    txtPrecoKm.Enabled = true;
                    txtKmDisponiveis.Enabled = true;
                }
            
        }

        private void cmbGrupoAutomoveis_SelectedIndexChanged(object sender, EventArgs e) {
            GrupoAutomovel grupo = (GrupoAutomovel)cmbGrupoAutomoveis.SelectedItem;
            CarregarTipos(grupo);
        }
    }
}
