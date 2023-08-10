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
    public partial class TelaDevolucaoAluguelForm : Form {
        Aluguel aluguel;

        IRepositorioCupom cupons;

        RepositorioPrecosJson repositorioPrecos;

        public event GravarRegistroDelegate<Aluguel> onGravarRegistro;

        bool cupomAplicado = false;
        bool configurado = false;

        public TelaDevolucaoAluguelForm(List<Funcionario> funcionarios, List<Cliente> clientes, List<Condutor> condutores, List<GrupoAutomovel> grupos, List<Automovel> automoveis, List<PlanoCobranca> planos, List<TaxaServico> taxas, IRepositorioCupom cupons, RepositorioPrecosJson repositorioPrecos) {
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

            listTaxasAdicionais.Items.Clear();
            foreach (TaxaServico item in taxas)
                if (listTaxasSelecionadas.Items.Contains(item) == false)
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
            cmbFuncionario.SelectedItem = aluguel.Funcionario;
            cmbCliente.SelectedItem = aluguel.Cliente;
            cmbCondutor.SelectedItem = aluguel.Condutor;
            cmbGrupoAutomovel.SelectedItem = aluguel.GrupoAutomovel;
            cmbAutomovel.SelectedItem = aluguel.Automovel;
            cmbPlanoCobranca.SelectedItem = aluguel.PlanoCobranca;
            txtKmAutomovel.Text = aluguel.Automovel.Quilometragem.ToString();
            txtCupom.Text = aluguel.Cupom.Nome;
            txtDataLocacao.Value = aluguel.DataLocacao;
            txtDataDevolucaoPrevista.Value = aluguel.DataDevolucaoPrevista;

            foreach (TaxaServico item in aluguel.TaxasSelecionadas) {
                listTaxasSelecionadas.SetItemChecked(listTaxasSelecionadas.Items.IndexOf(item), true);
            }

            foreach (TaxaServico item in aluguel.TaxasSelecionadas) {
                listTaxasSelecionadas.SetItemChecked(listTaxasAdicionais.Items.IndexOf(item), true);
            }

            txtValorTotal.Text = aluguel.ValorTotal.ToString();

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
            txtCupom.Text = aluguel.Cupom.Nome;
            txtDataLocacao.Value = aluguel.DataLocacao;
            txtDataDevolucaoPrevista.Value = aluguel.DataDevolucaoPrevista;
            txtDataDevolucao.Value = aluguel.DataDevolucao;
            txtKmPercorrida.Text = aluguel.KmPercorrido.ToString();
            cmbNivelTanque.SelectedItem = aluguel.NivelTanque;

            foreach (TaxaServico item in aluguel.TaxasSelecionadas) {
                listTaxasSelecionadas.SetItemChecked(listTaxasSelecionadas.Items.IndexOf(item), true);
            }

            foreach (TaxaServico item in aluguel.TaxasSelecionadas) {
                listTaxasSelecionadas.SetItemChecked(listTaxasAdicionais.Items.IndexOf(item), true);
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

        private decimal CalcularValorTotalFinal(Aluguel a) {

            if (a.PlanoCobranca.tipo == TipoPlanoEnum.PlanoLivre) return EncerrarAluguelPlanoLivre(a);
            else if (a.PlanoCobranca.tipo == TipoPlanoEnum.PlanoControlador) return EncerrarAluguelPlanoControlador(a);
            else if (a.PlanoCobranca.tipo == TipoPlanoEnum.PlanoDiario) return EncerrarAluguelPlanoDiario(a);

            return 0;

        }

        private decimal EncerrarAluguelPlanoLivre(Aluguel a) {

            decimal valorTotalPrevisto = CalcularValorTotalPrevisto(a);

            //verificar atraso

            TimeSpan diferenca = a.DataDevolucao - a.DataDevolucaoPrevista;
            int diasAtrasados = diferenca.Days;
            decimal multaAtraso = 0;
            if (diasAtrasados > 0) {
                multaAtraso = valorTotalPrevisto * (decimal)0.1;
                multaAtraso += diasAtrasados * 50;
            }

            //Verificar Combustivel

            int litrosUsados = VerificarCombustivel(a);
            decimal valorParaCompletarTanque = VerificarPrecoCombustivel(a.Automovel.TipoCombustivel, litrosUsados);

            decimal valorTotalFinal = valorTotalPrevisto + multaAtraso + valorParaCompletarTanque;

            return valorTotalFinal;
        }

        private decimal EncerrarAluguelPlanoControlador(Aluguel a) {

            decimal valorTotalPrevisto = CalcularValorTotalPrevisto(a);

            //verificar atraso

            TimeSpan diferenca = a.DataDevolucao - a.DataDevolucaoPrevista;
            int diasAtrasados = diferenca.Days;
            decimal multaAtraso = 0;
            if (diasAtrasados > 0) {
                multaAtraso = valorTotalPrevisto * (decimal)0.1;
                multaAtraso += diasAtrasados * 50;
            }

            //verificar kilometragem

            decimal multaKmExtrapolado = 0;
            int kmRodados = a.KmPercorrido - a.KmAutomovel;
            if (kmRodados > a.PlanoCobranca.KmDisponiveis) {
                multaKmExtrapolado = kmRodados * a.PlanoCobranca.PrecoKm;
            }


            //Verificar Combustivel

            int litrosUsados = VerificarCombustivel(a);
            decimal valorParaCompletarTanque = VerificarPrecoCombustivel(a.Automovel.TipoCombustivel, litrosUsados);

            decimal valorTotalFinal = valorTotalPrevisto + multaAtraso + multaKmExtrapolado + valorParaCompletarTanque;
            return valorTotalFinal;
        }

        private decimal EncerrarAluguelPlanoDiario(Aluguel a) {

            decimal valorTotalPrevisto = CalcularValorTotalPrevisto(a);

            //verificar atraso

            TimeSpan diferenca = a.DataDevolucao - a.DataDevolucaoPrevista;
            int diasAtrasados = diferenca.Days;
            decimal multaAtraso = 0;
            if (diasAtrasados > 0) {
                multaAtraso = valorTotalPrevisto * (decimal)0.1;
                multaAtraso += diasAtrasados * 50;
            }

            //verificar kilometragem


            int kmRodados = a.KmPercorrido - a.KmAutomovel;
            decimal valorKMRodados = kmRodados * a.PlanoCobranca.PrecoKm;


            //Verificar Combustivel

            int litrosUsados = VerificarCombustivel(a);
            decimal valorParaCompletarTanque = VerificarPrecoCombustivel(a.Automovel.TipoCombustivel, litrosUsados);

            decimal valorTotalFinal = valorTotalPrevisto + multaAtraso + valorKMRodados + valorParaCompletarTanque;

            return valorTotalFinal;
        }

        private decimal VerificarPrecoCombustivel(TipoCombustivelEnum tipoCombustivel, int litrosUsados) {

            var combustiveis = repositorioPrecos.ObterRegistros();

            decimal PrecoAlcool = 0;
            decimal PrecoGas = 0;
            decimal PrecoGasolina = 0;
            decimal PrecoDiesel = 0;

            foreach (var item in combustiveis) {
                PrecoAlcool = item.Alcool;
                PrecoGas = item.Gas;
                PrecoGasolina = item.Gasolina;
                PrecoDiesel = item.Diesel;
            }

            Decimal valorParaCompletarTanque = 0;
            if (tipoCombustivel == TipoCombustivelEnum.Gasolina) valorParaCompletarTanque = Convert.ToDecimal(litrosUsados * PrecoGasolina); //preço da Gasolina
            else if (tipoCombustivel == TipoCombustivelEnum.Alcool) valorParaCompletarTanque = Convert.ToDecimal(litrosUsados * PrecoAlcool); //preço do alcool
            else if (tipoCombustivel == TipoCombustivelEnum.Gas) valorParaCompletarTanque = Convert.ToDecimal(litrosUsados * PrecoGas); //preço do Gas
            else if (tipoCombustivel == TipoCombustivelEnum.Diesel) valorParaCompletarTanque = Convert.ToDecimal(litrosUsados * PrecoDiesel); //preço da Diesel

            return valorParaCompletarTanque;
        }

        private int VerificarCombustivel(Aluguel a) {

            int litrosUsados = 0;
            if (a.NivelTanque == TipoNivelTanqueEnum.Vazio) litrosUsados = a.Automovel.CapacidadeLitros;
            else if (a.NivelTanque == TipoNivelTanqueEnum.UmQuarto) litrosUsados = Convert.ToInt32((a.Automovel.CapacidadeLitros) * 0.75);
            else if (a.NivelTanque == TipoNivelTanqueEnum.UmMeio) litrosUsados = Convert.ToInt32((a.Automovel.CapacidadeLitros) * 0.5);
            else if (a.NivelTanque == TipoNivelTanqueEnum.TresQuartos) litrosUsados = Convert.ToInt32((a.Automovel.CapacidadeLitros) * 0.25);
            else if (a.NivelTanque == TipoNivelTanqueEnum.Cheio) litrosUsados = 0;

            return litrosUsados;
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

        private void AtualizaValorTotal(bool x) {
            if (x) {
                aluguel = ObterAluguel();
                txtValorTotal.Text = CalcularValorTotalFinal(aluguel).ToString();
            }
        }

        private void txtDataDevolucao_ValueChanged(object sender, EventArgs e) {
            AtualizaValorTotal(configurado);
        }

        private void cmbNivelTanque_SelectedIndexChanged(object sender, EventArgs e) {
            AtualizaValorTotal(configurado);
        }

        private void listTaxasAdicionais_ItemCheck(object sender, ItemCheckEventArgs e) {
            AtualizaValorTotal(configurado);
        }

        private void txtKmPercorrida_TextChanged(object sender, EventArgs e) {
            if (txtKmPercorrida.Text.Length < 1) {
                txtKmPercorrida.Text = "0";
            }
            AtualizaValorTotal(configurado);
        }

        private void txtKmPercorrida_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}