using LocadoraDeVeiculos.Aplicacao.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using FluentResults;
using LocadoraDeVeiculos.WinApp.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using LocadoraDeVeiculos.Dominio.ModuloTaxaServico;
using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Dominio.ModuloPrecos;
using LocadoraDeVeiculos.Infra.Json.ModuloPrecos;

namespace LocadoraDeVeiculos.WinApp.ModuloAluguel {
    public class ControladorAluguel : ControladorBase{
        IRepositorioAluguel repositorioAluguel;
        TabelaAluguelControl tabelaAluguel;
        ServicoAluguel servicoAluguel;

        IRepositorioFuncionario repositorioFuncionario;
        IRepositorioCliente repositorioCliente;
        IRepositorioCondutor repositorioCondutor;
        IRepositorioGrupoAutomovel repositorioGrupoAutomovel;
        IRepositorioAutomovel repositorioAutomovel;
        IRepositorioPlanoCobranca repositorioPlanoCobranca;
        IRepositorioTaxaServico repositorioTaxaServico;
        IRepositorioCupom repositorioCupom;
        RepositorioPrecosJson repositorioPrecos;

        public ControladorAluguel(IRepositorioAluguel repositorioAluguel, ServicoAluguel servicoAluguel, IRepositorioFuncionario repositorioFuncionario, IRepositorioCliente repositorioCliente, IRepositorioCondutor repositorioCondutor, IRepositorioGrupoAutomovel repositorioGrupoAutomovel, IRepositorioAutomovel repositorioAutomovel, IRepositorioPlanoCobranca repositorioPlanoCobranca, IRepositorioTaxaServico repositorioTaxaServico, IRepositorioCupom repositorioCupom, RepositorioPrecosJson repositorioPrecos){
            this.repositorioAluguel = repositorioAluguel;
            this.servicoAluguel = servicoAluguel;
            this.repositorioFuncionario = repositorioFuncionario;
            this.repositorioCliente = repositorioCliente;
            this.repositorioCondutor = repositorioCondutor;
            this.repositorioGrupoAutomovel = repositorioGrupoAutomovel;
            this.repositorioAutomovel = repositorioAutomovel;
            this.repositorioPlanoCobranca = repositorioPlanoCobranca;
            this.repositorioTaxaServico = repositorioTaxaServico;
            this.repositorioCupom = repositorioCupom;
            this.repositorioPrecos = repositorioPrecos;
        }

        public override void Inserir() {

            
            TelaAluguelForm tela = new(repositorioFuncionario.SelecionarTodos(), repositorioCliente.SelecionarTodos(),repositorioCondutor.SelecionarTodos(), repositorioGrupoAutomovel.SelecionarTodos(), repositorioAutomovel.SelecionarTodos(), repositorioPlanoCobranca.SelecionarTodos(), repositorioTaxaServico.SelecionarTodos(), repositorioCupom,repositorioPrecos);

            tela.onGravarRegistro += servicoAluguel.Inserir;

            tela.ConfigurarAluguel(new Aluguel());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarAlugueis();
            }
        }

        
        public override void Editar() {
            Guid id = tabelaAluguel.ObtemIdSelecionado();

            Aluguel aluguelSelecionada = repositorioAluguel.SelecionarPorId(id);

            if (aluguelSelecionada == null) {
                MessageBox.Show("Selecione um aluguel primeiro",
                "Edição de Aluguéis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaAluguelForm tela = new(repositorioFuncionario.SelecionarTodos(), repositorioCliente.SelecionarTodos(), repositorioCondutor.SelecionarTodos(), repositorioGrupoAutomovel.SelecionarTodos(), repositorioAutomovel.SelecionarTodos(), repositorioPlanoCobranca.SelecionarTodos(), repositorioTaxaServico.SelecionarTodos(), repositorioCupom,repositorioPrecos);

            tela.onGravarRegistro += servicoAluguel.Editar;

            tela.ConfigurarAluguel(aluguelSelecionada);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarAlugueis();
            }
        }

        public override void Excluir() {
            Guid id = tabelaAluguel.ObtemIdSelecionado();

            Aluguel aluguelSelecionada = repositorioAluguel.SelecionarPorId(id);

            if (aluguelSelecionada == null) {
                MessageBox.Show("Selecione uma aluguel primeiro",
                "Exclusão de Aluguéis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show("Deseja realmente excluir o aluguel?",
               "Exclusão de Aluguéis", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK) {
                Result resultado = servicoAluguel.Excluir(aluguelSelecionada);

                if (resultado.IsFailed) {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Aluguéis",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                CarregarAlugueis();
            }
        }

        public override void ConfigurarPreco() {
            Precos registroPreco = repositorioPrecos.ObterRegistros().FirstOrDefault();

            if (registroPreco == null) {
                registroPreco = new Precos(Guid.NewGuid(), 0, 0, 0, 0);
            }

            TelaPrecoForm tela = new TelaPrecoForm(registroPreco);
            tela.ConfigurarPrecos(registroPreco);

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {
                Precos precoEscolhido = tela.ObterPrecos();
                repositorioPrecos.Salvar(registroPreco);
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox() {
            return new ConfigurarToolBoxAluguel();
        }

        public override UserControl ObtemListagem() {
            if (tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();
            CarregarAlugueis();

            return tabelaAluguel;
        }

        private void CarregarAlugueis() {
            List<Aluguel> alugueis = repositorioAluguel.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(alugueis);

            mensagemRodape = string.Format("Visualizando {0} alugue{1}", alugueis.Count, alugueis.Count == 1 ? "l" : "éis");

            TelaPrincipalForm.Instancia.AtualizarRodape(mensagemRodape);
        }
    }
}
