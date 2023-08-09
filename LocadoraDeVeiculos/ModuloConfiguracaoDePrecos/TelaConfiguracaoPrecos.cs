using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloConfiguracaoDePrecos;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
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

namespace LocadoraDeVeiculos.WinApp.ModuloConfiguracaoDePrecos {
    public partial class TelaConfiguracaoPrecos : Form {

        private ConfiguracaoDePreco configuracaoDePreco;
        public List<ConfiguracaoDePreco> configuracoes;

        public event GravarRegistroDelegate<ConfiguracaoDePreco> onGravarRegistro;
        public TelaConfiguracaoPrecos(List<ConfiguracaoDePreco> configuracoes) {
            this.configuracoes= configuracoes;
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public void ConfigurarPrecos(ConfiguracaoDePreco configuracaoDePreco) {
            this.configuracaoDePreco = configuracaoDePreco;
            txtAlcool.Text = configuracaoDePreco.PrecoAlcool.ToString();
            txtGas.Text = configuracaoDePreco.PrecoGas.ToString();
            txtGasolina.Text = configuracaoDePreco.PrecoGasolina.ToString();
            txtDiesel.Text = configuracaoDePreco.PrecoDiesel.ToString();
            
        }



        public ConfiguracaoDePreco ObterConfiguracaoDePrecos() {

            configuracaoDePreco.PrecoAlcool = Convert.ToDecimal(txtAlcool.Text);
            configuracaoDePreco.PrecoGas = Convert.ToDecimal(txtGas.Text);
            configuracaoDePreco.PrecoGasolina = Convert.ToDecimal(txtGasolina.Text);
            configuracaoDePreco.PrecoDiesel = Convert.ToDecimal(txtDiesel.Text);

            
            return configuracaoDePreco;
        }

        private void btnGravar_Click(object sender, EventArgs e) {
            this.configuracaoDePreco = ObterConfiguracaoDePrecos();

            Result resultado = onGravarRegistro(configuracaoDePreco);

            if (resultado.IsFailed) {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }


    }
}
