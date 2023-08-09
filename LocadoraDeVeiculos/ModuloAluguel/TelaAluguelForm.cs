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
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloAluguel {
    public partial class TelaAluguelForm : Form {

        Aluguel aluguel;

        IRepositorioCupom cupons;

        public event GravarRegistroDelegate<Aluguel> onGravarRegistro;

        public TelaAluguelForm(List<Funcionario> funcionarios, List<Cliente> clientes, List<Condutor> condutores, List<GrupoAutomovel> grupos, List<Automovel> automoveis, List<PlanoCobranca> planos, List<TaxaServico> taxas, IRepositorioCupom cupons) {
            InitializeComponent();
            this.ConfigurarDialog();
            ConfigurarComboBox(funcionarios, clientes, condutores, grupos, automoveis, planos, taxas);
            this.cupons = cupons;
        }

        private void ConfigurarComboBox(List<Funcionario> funcionarios, List<Cliente> clientes, List<Condutor> condutores, List<GrupoAutomovel> grupos, List<Automovel> automoveis, List<PlanoCobranca> planos, List<TaxaServico> taxas) {
            cmbFuncionario.Items.Clear();
            foreach (Funcionario item in funcionarios)
                cmbFuncionario.Items.Add(item);
            cmbCliente.Items.Clear();
            foreach (Cliente item in clientes)
                cmbCliente.Items.Add(item);
            cmbCondutor.Items.Clear();
            foreach (Condutor item in condutores)
                cmbCondutor.Items.Add(item);
            cmbGrupoAutomovel.Items.Clear();
            foreach (GrupoAutomovel item in grupos)
                cmbGrupoAutomovel.Items.Add(item);
            cmbAutomovel.Items.Clear();
            foreach (Automovel item in automoveis)
                cmbAutomovel.Items.Add(item);
            cmbPlanoCobranca.Items.Clear();
            foreach (PlanoCobranca item in planos)
                cmbPlanoCobranca.Items.Add(item);
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
                        
            Cupom cupom = cupons.SelecionarPorNome(txtCupom.Text);
            if (cupom != null) aluguel.Cupom = cupom;

            foreach (TaxaServico item in listTaxasSelecionadas.CheckedItems)
            {
                aluguel.TaxasSelecionadas.Add(item);
            }

            aluguel.ValorTotal = CalcularValorTotalPrevisto(aluguel);

            return aluguel;
        }

        public void ConfigurarAluguel(Aluguel aluguel) {
            this.aluguel = aluguel;
            if (aluguel == null) {
                cmbFuncionario.SelectedItem = aluguel.Funcionario;
                cmbCliente.SelectedItem = aluguel.Cliente;
                cmbCondutor.SelectedItem = aluguel.Condutor;
                cmbGrupoAutomovel.SelectedItem = aluguel.GrupoAutomovel;
                cmbAutomovel.SelectedItem = aluguel.Automovel;
                cmbPlanoCobranca.SelectedItem = aluguel.PlanoCobranca;
                txtKmAutomovel.Text = aluguel.KmAutomovel.ToString();
                txtCupom.Text = aluguel.Cupom.Nome;

                foreach (TaxaServico item in aluguel.TaxasSelecionadas)
                {
                    listTaxasSelecionadas.SetItemChecked(listTaxasSelecionadas.Items.IndexOf(item), true);
                }

                txtValorTotal.Text = aluguel.ValorTotal.ToString();
            }
        }

        private decimal CalcularValorTotalPrevisto(Aluguel a) {

            //valor das diarias
            TimeSpan diasPrevistos = a.DataDevolucao - a.DataDevolucaoPrevista;
            int dias = diasPrevistos.Days;
            decimal valorDiariasPrevistas = dias * a.PlanoCobranca.PrecoDiaria;

            //valor do cupom
            decimal valorCupom = a.Cupom.Valor;

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

        
    }
}
