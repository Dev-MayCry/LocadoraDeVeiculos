using LocadoraDeVeiculos.Dominio.ModuloPrecos;
using LocadoraDeVeiculos.WinApp.Compartilhado;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WinApp.ModuloAluguel {
    public partial class TelaPrecoForm : Form {

        private Precos precos;
        public event GravarRegistroDelegate<Precos> onGravarRegistro;
        public TelaPrecoForm(Precos registro) {
            InitializeComponent();
            this.ConfigurarDialog();
            this.precos = registro;
        }

            public Precos ObterPrecos() {
                precos.Gasolina = Convert.ToInt32(txtGasolina.Text);
                precos.Gas = Convert.ToInt32(txtGas.Text);
                precos.Diesel = Convert.ToInt32(txtDiesel.Text);
                precos.Alcool = Convert.ToInt32(txtAlcool.Text);

                return precos;
            }

            public void ConfigurarPrecos(Precos precos) {
                txtGasolina.Text = precos.Gasolina.ToString();
                txtGas.Text = precos.Gas.ToString();
                txtDiesel.Text = precos.Diesel.ToString();
                txtAlcool.Text = precos.Alcool.ToString();
            }
        
    }
}
