﻿using LocadoraDeVeiculos.Aplicacao.ModuloFuncionario;
using LocadoraDeVeiculos.Aplicacao.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Aplicacao.ModuloParceiro;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.Infra.Orm.ModuloFuncionario;
using LocadoraDeVeiculos.Infra.Orm.ModuloParceiro;
using LocadoraDeVeiculos.Infra.Orm.Compartilhado;
using LocadoraDeVeiculos.WinApp.Compartilhado;
using LocadoraDeVeiculos.WinApp.ModuloFuncionario;
using LocadoraDeVeiculos.WinApp.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.WinApp.ModuloParceiro;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LocadoraDeVeiculos.Infra.Orm.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Infra.Orm.ModuloAutomovel;
using LocadoraDeVeiculos.Aplicacao.ModuloAutomovel;
using LocadoraDeVeiculos.WinApp.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using LocadoraDeVeiculos.Aplicacao.ModuloPlanoCobranca;
using LocadoraDeVeiculos.Infra.Orm.ModuloPlanoCobranca;
using LocadoraDeVeiculos.WinApp.ModuloPlanoCobranca;
using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Infra.Orm.ModuloCupom;
using LocadoraDeVeiculos.Aplicacao.ModuloCupom;
using LocadoraDeVeiculos.WinApp.ModuloCupom;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Infra.Orm.ModuloCliente;
using LocadoraDeVeiculos.Aplicacao.ModuloCliente;
using LocadoraDeVeiculos.WinApp.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloTaxaServico;
using LocadoraDeVeiculos.Aplicacao.ModuloTaxaServico;
using LocadoraDeVeiculos.Infra.Orm.ModuloTaxaServico;
using LocadoraDeVeiculos.WinApp.ModuloTaxaServico;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Infra.Orm.ModuloCondutor;
using LocadoraDeVeiculos.Aplicacao.ModuloCondutor;
using LocadoraDeVeiculos.WinApp.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Infra.Orm.ModuloAluguel;
using LocadoraDeVeiculos.Aplicacao.ModuloAluguel;
using LocadoraDeVeiculos.WinApp.ModuloAluguel;
using LocadoraDeVeiculos.Infra.Json.ModuloPrecos;
using LocadoraDeVeiculos.Infra.Json.Serializadores;
using LocadoraDeVeiculos.Infra.Pdf;

namespace LocadoraDeVeiculos {
    public partial class TelaPrincipalForm : Form {


        private Dictionary<string, ControladorBase> controladores;

        private ControladorBase controlador;
        public TelaPrincipalForm() {
            InitializeComponent();
            Instancia = this;

            labelRodape.Text = string.Empty;
            labelTipoCadastro.Text = string.Empty;

            controladores = new Dictionary<string, ControladorBase>();

            ConfigurarControladores();
        }
        public static TelaPrincipalForm Instancia {
            get;
            private set;
        }

        public void AtualizarRodape(string mensagem) {
            labelRodape.Text = mensagem;
        }

        private void ConfigurarControladores() {
            var configuracao = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var connectionString = configuracao.GetConnectionString("SqlServer");

            var optionsBuilder = new DbContextOptionsBuilder<LocadoraDeVeiculosDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            var dbContext = new LocadoraDeVeiculosDbContext(optionsBuilder.Options);

            var migracoesPendentes = dbContext.Database.GetPendingMigrations();

            if (migracoesPendentes.Count() > 0) {
                dbContext.Database.Migrate();
            }

            IRepositorioParceiro repositorioParceiro = new RepositorioParceiroOrm(dbContext);

            ValidadorParceiro validadorParceiro = new ValidadorParceiro();

            ServicoParceiro servicoParceiro = new ServicoParceiro(repositorioParceiro, validadorParceiro);

            controladores.Add("ControladorParceiro", new ControladorParceiro(repositorioParceiro, servicoParceiro));


            IRepositorioGrupoAutomovel repositorioGrupoAutomovel = new RepositorioGrupoAutomovelOrm(dbContext);

            ValidadorGrupoAutomovel validadorGrupoAutomovel = new();

            ServicoGrupoAutomovel servicoGrupoAutomovel = new(repositorioGrupoAutomovel, validadorGrupoAutomovel);

            controladores.Add("ControladorGrupoAutomovel", new ControladorGrupoAutomovel(repositorioGrupoAutomovel, servicoGrupoAutomovel));


            IRepositorioFuncionario repositorioFuncionario = new RepositorioFuncionarioOrm(dbContext);

            ValidadorFuncionario validadorFuncionario = new ValidadorFuncionario();

            ServicoFuncionario servicoFuncionario = new ServicoFuncionario(repositorioFuncionario, validadorFuncionario);

            controladores.Add("ControladorFuncionario", new ControladorFuncionario(repositorioFuncionario, servicoFuncionario));


            IRepositorioAutomovel repositorioAutomovel = new RepositorioAutomovelOrm(dbContext);

            ValidadorAutomovel validadorAutomovel = new ValidadorAutomovel();

            ServicoAutomovel servicoAutomovel = new ServicoAutomovel(repositorioAutomovel, validadorAutomovel);

            controladores.Add("ControladorAutomovel", new ControladorAutomovel(repositorioAutomovel, servicoAutomovel, repositorioGrupoAutomovel));


            IRepositorioPlanoCobranca repositorioPlanoCobranca = new RepositorioPlanoCobrancaOrm(dbContext);

            ValidadorPlanoCobranca validadorPlanoCobranca = new();

            ServicoPlanoCobranca servicoPlanoCobranca = new(repositorioPlanoCobranca, validadorPlanoCobranca);

            controladores.Add("ControladorPlanoCobranca", new ControladorPlanoCobranca(repositorioPlanoCobranca, servicoPlanoCobranca, repositorioGrupoAutomovel));


            IRepositorioTaxaServico repositorioTaxaServico = new RepositorioTaxaServicoOrm(dbContext);

            ValidadorTaxaServico validadorTaxaServico = new();

            ServicoTaxaServico servicoTaxaServico = new(repositorioTaxaServico, validadorTaxaServico);

            controladores.Add("ControladorTaxaServico", new ControladorTaxaServico(repositorioTaxaServico, servicoTaxaServico));


            IRepositorioCupom repositorioCupom = new RepositorioCupomOrm(dbContext);

            ValidadorCupom validadorCupom = new ValidadorCupom();

            ServicoCupom servicoCupom = new(repositorioCupom, validadorCupom);

            controladores.Add("ControladorCupom", new ControladorCupom(repositorioCupom, servicoCupom, repositorioParceiro));


            IRepositorioCliente repositorioCliente = new RepositorioClienteOrm(dbContext);

            ValidadorCliente validadorCliente = new ValidadorCliente();

            ServicoCliente servicoCliente = new ServicoCliente(repositorioCliente, validadorCliente);

            controladores.Add("ControladorCliente", new ControladorCliente(repositorioCliente, servicoCliente));


            IRepositorioCondutor repositorioCondutor = new RepositorioCondutorOrm(dbContext);

            ValidadorCondutor validadorCondutor = new ValidadorCondutor();

            ServicoCondutor servicoCondutor = new ServicoCondutor(repositorioCondutor, validadorCondutor);

            controladores.Add("ControladorCondutor", new ControladorCondutor(repositorioCondutor, servicoCondutor, repositorioCliente));


            IRepositorioAluguel repositorioAluguel = new RepositorioAluguelOrm(dbContext);

            SerializadorDadosEmJson serializador = new SerializadorDadosEmJson();

            ContextoDadosPrecos contexto = new ContextoDadosPrecos(serializador);

            IGeradorArquivo geradorArquivo = new GeradorAluguelEmPdf();

            RepositorioPrecosJson repositorioPrecos = new RepositorioPrecosJson(contexto);

            ValidadorAluguel validadorAluguel = new ValidadorAluguel();

            ServicoAluguel servicoAluguel = new ServicoAluguel(repositorioAluguel, validadorAluguel, geradorArquivo);

            controladores.Add("ControladorAluguel", new ControladorAluguel(repositorioAluguel, servicoAluguel, repositorioFuncionario, repositorioCliente, repositorioCondutor, repositorioGrupoAutomovel, repositorioAutomovel, repositorioPlanoCobranca, repositorioTaxaServico, repositorioCupom, repositorioPrecos));


        }
        private void cupomToolStripMenuItem_Click(object sender, EventArgs e) {
            ConfigurarTelaPrincipal(controladores["ControladorCupom"]);
        }
        private void clienteMenuItem_Click(object sender, EventArgs e) {
            ConfigurarTelaPrincipal(controladores["ControladorCliente"]);
        }
        private void disciplinaMenuItem_Click(object sender, EventArgs e) {
            ConfigurarTelaPrincipal(controladores["ControladorParceiro"]);
        }
        private void grupoDeAutomoveisMenuItem_Click(object sender, EventArgs e) {
            ConfigurarTelaPrincipal(controladores["ControladorGrupoAutomovel"]);
        }
        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e) {
            ConfigurarTelaPrincipal(controladores["ControladorFuncionario"]);
        }
        private void automóvelToolStripMenuItem_Click(object sender, EventArgs e) {
            ConfigurarTelaPrincipal(controladores["ControladorAutomovel"]);
        }
        private void planoECobrançaToolStripMenuItem_Click(object sender, EventArgs e) {
            ConfigurarTelaPrincipal(controladores["ControladorPlanoCobranca"]);
        }
        private void taxaEServiçoToolStripMenuItem_Click(object sender, EventArgs e) {
            ConfigurarTelaPrincipal(controladores["ControladorTaxaServico"]);
        }
        private void condutorToolStripMenuItem_Click(object sender, EventArgs e) {
            ConfigurarTelaPrincipal(controladores["ControladorCondutor"]);
        }
        private void aluguelToolStripMenuItem_Click(object sender, EventArgs e) {
            ConfigurarTelaPrincipal(controladores["ControladorAluguel"]);
        }
        private void ConfigurarBotoes(ConfiguracaoToolboxBase configuracao) {
            btnInserir.Enabled = configuracao.InserirHabilitado;
            btnEditar.Enabled = configuracao.EditarHabilitado;
            btnExcluir.Enabled = configuracao.ExcluirHabilitado;
            btnConfigurar.Enabled = configuracao.ConfigurarHabilitado;
            btnFiltrar.Enabled = configuracao.FiltrarHabilitado;
            btnEncerrar.Enabled = configuracao.EncerrarHabilitado;
        }

        private void ConfigurarTooltips(ConfiguracaoToolboxBase configuracao) {
            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;
            btnConfigurar.ToolTipText = configuracao.TooltipConfigurar;
            btnFiltrar.ToolTipText = configuracao.TooltipFiltrar;
            btnEncerrar.ToolTipText = configuracao.TooltipEncerrar;
        }

        private void ConfigurarTelaPrincipal(ControladorBase controlador) {
            this.controlador = controlador;

            ConfigurarToolbox();

            ConfigurarListagem();

            string mensagemRodape = controlador.ObterMensagemRodape();

            AtualizarRodape(mensagemRodape);
        }

        private void ConfigurarToolbox() {
            ConfiguracaoToolboxBase configuracao = controlador.ObtemConfiguracaoToolbox();

            if (configuracao != null) {
                toolbox.Enabled = true;

                labelTipoCadastro.Text = configuracao.TipoCadastro;

                ConfigurarTooltips(configuracao);

                ConfigurarBotoes(configuracao);
            }
        }

        private void ConfigurarListagem() {
            AtualizarRodape("");

            var listagemControl = controlador.ObtemListagem();

            panelRegistros.Controls.Clear();

            listagemControl.Dock = DockStyle.Fill;

            panelRegistros.Controls.Add(listagemControl);
        }

        private void btnInserir_Click(object sender, EventArgs e) {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            controlador.Excluir();
        }

        private void btnFiltrar_Click(object sender, EventArgs e) {
            controlador.Filtrar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            controlador.ConfigurarPreco();
        }

        private void btnEncerrar_Click(object sender, EventArgs e) {
            controlador.Encerrar();
        }
    }
}
