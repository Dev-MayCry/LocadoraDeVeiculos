using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using LocadoraDeVeiculos.Dominio.ModuloTaxaServico;
using LocadoraDeVeiculos.Infra.Json.ModuloPrecos;
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloAluguel {
    public partial class TelaAluguelForm : Form {

        Aluguel aluguel;

        IRepositorioCupom cupons;

        RepositorioPrecosJson repositorioPrecos;

        public event GravarRegistroDelegate<Aluguel> onGravarRegistro;

        bool cupomAplicado = false;
        bool configurado = false;

        public TelaAluguelForm(List<Funcionario> funcionarios, List<Cliente> clientes, List<Condutor> condutores, List<GrupoAutomovel> grupos, List<Automovel> automoveis, List<PlanoCobranca> planos, List<TaxaServico> taxas, IRepositorioCupom cupons, RepositorioPrecosJson repositorioPrecos) {
            InitializeComponent();
            this.ConfigurarDialog();
            ConfigurarComboBox(funcionarios, clientes, condutores, grupos, automoveis, planos, taxas);
            this.cupons = cupons;
            this.repositorioPrecos = repositorioPrecos;
        }

        private void ConfigurarComboBox(List<Funcionario> funcionarios, List<Cliente> clientes, List<Condutor> condutores, List<GrupoAutomovel> grupos, List<Automovel> automoveis, List<PlanoCobranca> planos, List<TaxaServico> taxas) {
            cmbFuncionario.Items.Clear();
            foreach (Funcionario item in funcionarios)
                cmbFuncionario.Items.Add(item);
            cmbFuncionario.SelectedIndex = 0;

            cmbCliente.Items.Clear();
            foreach (Cliente item in clientes)
                cmbCliente.Items.Add(item);
            cmbCliente.SelectedIndex = 0;

            cmbCondutor.Items.Clear();
            foreach (Condutor item in condutores)
                cmbCondutor.Items.Add(item);
            cmbCondutor.SelectedIndex = 0;

            cmbGrupoAutomovel.Items.Clear();
            foreach (GrupoAutomovel item in grupos)
                cmbGrupoAutomovel.Items.Add(item);
            cmbGrupoAutomovel.SelectedIndex = 0;

            cmbAutomovel.Items.Clear();
            foreach (Automovel item in automoveis)
                cmbAutomovel.Items.Add(item);
            cmbAutomovel.SelectedIndex = 0;

            cmbPlanoCobranca.Items.Clear();
            foreach (PlanoCobranca item in planos)
                cmbPlanoCobranca.Items.Add(item);
            cmbPlanoCobranca.SelectedIndex = 0;

            listTaxasSelecionadas.Items.Clear();
            foreach (TaxaServico item in taxas)
                listTaxasSelecionadas.Items.Add(item);
        }

        public Aluguel ObterAluguel() {
            aluguel.Funcionario = (Funcionario)cmbFuncionario.SelectedItem;
            aluguel.Cliente = (Cliente)cmbCliente.SelectedItem;
            aluguel.Condutor = (Condutor)cmbCondutor.SelectedItem;
            aluguel.GrupoAutomovel = (GrupoAutomovel)cmbGrupoAutomovel.SelectedItem;
            aluguel.Automovel = (Automovel)cmbAutomovel.SelectedItem;
            aluguel.PlanoCobranca = (PlanoCobranca)cmbPlanoCobranca.SelectedItem;
            aluguel.KmAutomovel = Convert.ToInt32(txtKmAutomovel.Text);
            aluguel.DataLocacao = txtDataLocacao.Value;
            aluguel.DataDevolucaoPrevista = txtDataDevolucaoPrevista.Value;

            Cupom cupom = cupons.SelecionarPorNome(txtCupom.Text);
            if (cupomAplicado) aluguel.Cupom = cupom;

            aluguel.TaxasSelecionadas.Clear();

            foreach (TaxaServico item in listTaxasSelecionadas.CheckedItems) {
                aluguel.TaxasSelecionadas.Add(item);
            }

            aluguel.ValorTotal = CalcularValorTotalPrevisto(aluguel);

            return aluguel;
        }


        public void ConfigurarAluguel(Aluguel aluguel) {
            this.aluguel = aluguel;
            configurado = true;
        }

        public void ConfigurarAluguelEdicao(Aluguel aluguel) {
            this.aluguel = aluguel;
            cmbFuncionario.SelectedItem = aluguel.Funcionario;
            cmbCliente.SelectedItem = aluguel.Cliente;
            cmbCondutor.SelectedItem = aluguel.Condutor;
            cmbGrupoAutomovel.SelectedItem = aluguel.GrupoAutomovel;
            cmbAutomovel.SelectedItem = aluguel.Automovel;
            cmbPlanoCobranca.SelectedItem = aluguel.PlanoCobranca;
            txtKmAutomovel.Text = aluguel.Automovel.Quilometragem.ToString();

            if(aluguel.Cupom !=null)txtCupom.Text = aluguel.Cupom.Nome;
            txtDataLocacao.Value = aluguel.DataLocacao;
            txtDataDevolucaoPrevista.Value = aluguel.DataDevolucaoPrevista;

            foreach (TaxaServico item in aluguel.TaxasSelecionadas) {
                listTaxasSelecionadas.SetItemChecked(listTaxasSelecionadas.Items.IndexOf(item), true);
            }

            txtValorTotal.Text = aluguel.ValorTotal.ToString();

            configurado = true;
        }

        private decimal CalcularValorTotalPrevisto(Aluguel a) {

            //valor das diarias
            DateTime dataDevolucaoPrevista = a.DataDevolucaoPrevista.Date;
            DateTime dataLocacao = a.DataLocacao.Date;
            TimeSpan diasPrevistos = dataDevolucaoPrevista - dataLocacao;
            int dias = diasPrevistos.Days;
            decimal valorDiariasPrevistas = dias * a.PlanoCobranca.PrecoDiaria;

            //valor do cupom
            decimal valorCupom = 0;
            if (a.Cupom != null)
                valorCupom = a.Cupom.Valor;

            //valor das taxas
            decimal valorTaxas = 0;
            foreach (var item in a.TaxasSelecionadas) {
                valorTaxas += item.Preco;
            }

            //valor total

            decimal valorTotalPrevisto = valorDiariasPrevistas + valorTaxas - valorCupom;

            return valorTotalPrevisto;

        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            aluguel = ObterAluguel();

            Result resultado = onGravarRegistro(aluguel);

            if (resultado.IsFailed) {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void txtKmAutomovel_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtKmAutomovel_TextChanged(object sender, EventArgs e) {
            if (txtKmAutomovel.Text.Length < 1) {
                txtKmAutomovel.Text = "0";
            }
        }

        private void btnAplicarCupom_Click(object sender, EventArgs e) {
            Cupom cupom = cupons.SelecionarPorNome(txtCupom.Text);
            
            if (cupom != null && cupom.DataValidade > DateTime.Today) {
                cupomAplicado = true;
                txtCupom.ReadOnly = true;
            } else {
                MessageBox.Show("Cupom Inválido ou expirado!","Aplicação de Cupom",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            AtualizaValorTotal(configurado);
        }

        private void AtualizaValorTotal(bool x) {
            if (x) {
                aluguel = ObterAluguel();
                txtValorTotal.Text = CalcularValorTotalPrevisto(aluguel).ToString();
            }
        }

        private void cmbAutomovel_SelectedIndexChanged(object sender, EventArgs e) {
            Automovel automovel = (Automovel)cmbAutomovel.SelectedItem;
            txtKmAutomovel.Text = automovel.Quilometragem.ToString();
        }

        private void cmbPlanoCobranca_SelectedIndexChanged(object sender, EventArgs e) {
            AtualizaValorTotal(configurado);
        }

        private void txtDataDevolucaoPrevista_ValueChanged(object sender, EventArgs e) {
            AtualizaValorTotal(configurado);
        }

        private void txtDataLocacao_ValueChanged(object sender, EventArgs e) {
            AtualizaValorTotal(configurado);
        }

        private void listTaxasSelecionadas_ItemCheck(object sender, ItemCheckEventArgs e) {

            AtualizaValorTotal(configurado);

        }

        private void cmbGrupoAutomovel_SelectedIndexChanged(object sender, EventArgs e) {
            AtualizaValorTotal(configurado);
        }

        
    }
    
}
