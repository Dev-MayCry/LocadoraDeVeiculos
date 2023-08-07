using LocadoraDeVeiculos.Aplicacao.ModuloFuncionario;
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
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using LocadoraDeVeiculos.Aplicacao.ModuloPlanoCobranca;
using LocadoraDeVeiculos.Infra.Orm.ModuloPlanoCobranca;
using LocadoraDeVeiculos.WinApp.ModuloPlanoCobranca;

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

            IRepositorioFuncionario repositorioFuncionario = new RepositorioFuncionarioOrm(dbContext);

            IRepositorioGrupoAutomovel repositorioGrupoAutomovel = new RepositorioGrupoAutomovelOrm(dbContext);

            ValidadorGrupoAutomovel validadorGrupoAutomovel = new();

            ServicoGrupoAutomovel servicoGrupoAutomovel = new(repositorioGrupoAutomovel, validadorGrupoAutomovel);

            controladores.Add("ControladorGrupoAutomovel", new ControladorGrupoAutomovel(repositorioGrupoAutomovel, servicoGrupoAutomovel));


            ValidadorFuncionario validadorFuncionario = new ValidadorFuncionario();

            ServicoFuncionario servicoFuncionario = new ServicoFuncionario(repositorioFuncionario, validadorFuncionario);

            controladores.Add("ControladorFuncionario", new ControladorFuncionario(repositorioFuncionario, servicoFuncionario));


            IRepositorioPlanoCobranca repositorioPlanoCobranca = new RepositorioPlanoCobrancaOrm(dbContext);

            ValidadorPlanoCobranca validadorPlanoCobranca = new();

            ServicoPlanoCobranca servicoPlanoCobranca = new(repositorioPlanoCobranca,validadorPlanoCobranca);


            controladores.Add("ControladorPlanoCobranca", new ControladorPlanoCobranca(repositorioPlanoCobranca, servicoPlanoCobranca,repositorioGrupoAutomovel));

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

        private void planoECobrançaToolStripMenuItem_Click(object sender, EventArgs e) {
            ConfigurarTelaPrincipal(controladores["ControladorPlanoCobranca"]);
        }

        private void ConfigurarBotoes(ConfiguracaoToolboxBase configuracao) {
            btnInserir.Enabled = configuracao.InserirHabilitado;
            btnEditar.Enabled = configuracao.EditarHabilitado;

            btnExcluir.Enabled = configuracao.ExcluirHabilitado;

        }

        private void ConfigurarTooltips(ConfiguracaoToolboxBase configuracao) {
            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;

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

        
    }
}
