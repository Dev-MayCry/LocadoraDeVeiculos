namespace LocadoraDeVeiculos
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoDeAutomóvelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planoECobrançaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxaEServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aluguelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automóvelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cupomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoDePreçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbox = new System.Windows.Forms.ToolStrip();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnFiltrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.labelTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            this.panelRegistros = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelRodape = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu.SuspendLayout();
            this.toolbox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteMenuItem,
            this.disciplinaMenuItem,
            this.funcionárioToolStripMenuItem,
            this.grupoDeAutomóvelToolStripMenuItem,
            this.condutorToolStripMenuItem,
            this.planoECobrançaToolStripMenuItem,
            this.taxaEServiçoToolStripMenuItem,
            this.aluguelToolStripMenuItem,
            this.automóvelToolStripMenuItem,
            this.cupomToolStripMenuItem,
            this.configuraçãoDePreçosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clienteMenuItem
            // 
            this.clienteMenuItem.Name = "clienteMenuItem";
            this.clienteMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.clienteMenuItem.Size = new System.Drawing.Size(204, 22);
            this.clienteMenuItem.Text = "Cliente";
            this.clienteMenuItem.Click += new System.EventHandler(this.clienteMenuItem_Click);
            // 
            // disciplinaMenuItem
            // 
            this.disciplinaMenuItem.Name = "disciplinaMenuItem";
            this.disciplinaMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.disciplinaMenuItem.Size = new System.Drawing.Size(204, 22);
            this.disciplinaMenuItem.Text = "Parceiro";
            this.disciplinaMenuItem.Click += new System.EventHandler(this.disciplinaMenuItem_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // grupoDeAutomóvelToolStripMenuItem
            // 
            this.grupoDeAutomóvelToolStripMenuItem.Name = "grupoDeAutomóvelToolStripMenuItem";
            this.grupoDeAutomóvelToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.grupoDeAutomóvelToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.grupoDeAutomóvelToolStripMenuItem.Text = "Grupo de Automóvel";
            this.grupoDeAutomóvelToolStripMenuItem.Click += new System.EventHandler(this.grupoDeAutomoveisMenuItem_Click);
            // 
            // condutorToolStripMenuItem
            // 
            this.condutorToolStripMenuItem.Name = "condutorToolStripMenuItem";
            this.condutorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.condutorToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.condutorToolStripMenuItem.Text = "Condutor";
            // 
            // planoECobrançaToolStripMenuItem
            // 
            this.planoECobrançaToolStripMenuItem.Name = "planoECobrançaToolStripMenuItem";
            this.planoECobrançaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.planoECobrançaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.planoECobrançaToolStripMenuItem.Text = "Plano e Cobrança";
            this.planoECobrançaToolStripMenuItem.Click += new System.EventHandler(this.planoECobrançaToolStripMenuItem_Click);
            // 
            // taxaEServiçoToolStripMenuItem
            // 
            this.taxaEServiçoToolStripMenuItem.Name = "taxaEServiçoToolStripMenuItem";
            this.taxaEServiçoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.taxaEServiçoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.taxaEServiçoToolStripMenuItem.Text = "Taxa e Serviço";
            // 
            // aluguelToolStripMenuItem
            // 
            this.aluguelToolStripMenuItem.Name = "aluguelToolStripMenuItem";
            this.aluguelToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.aluguelToolStripMenuItem.Text = "Aluguel";
            // 
            // automóvelToolStripMenuItem
            // 
            this.automóvelToolStripMenuItem.Name = "automóvelToolStripMenuItem";
            this.automóvelToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.automóvelToolStripMenuItem.Text = "Automóvel";
            // 
            // cupomToolStripMenuItem
            // 
            this.cupomToolStripMenuItem.Name = "cupomToolStripMenuItem";
            this.cupomToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.cupomToolStripMenuItem.Text = "Cupom";
            // 
            // configuraçãoDePreçosToolStripMenuItem
            // 
            this.configuraçãoDePreçosToolStripMenuItem.Name = "configuraçãoDePreçosToolStripMenuItem";
            this.configuraçãoDePreçosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.configuraçãoDePreçosToolStripMenuItem.Text = "Configuração de Preços";
            this.configuraçãoDePreçosToolStripMenuItem.Click += new System.EventHandler(this.configuraçãoDePreçosToolStripMenuItem_Click);
            // 
            // toolbox
            // 
            this.toolbox.Enabled = false;
            this.toolbox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInserir,
            this.btnEditar,
            this.btnExcluir,
            this.btnFiltrar,
            this.toolStripSeparator2,
            this.labelTipoCadastro});
            this.toolbox.Location = new System.Drawing.Point(0, 24);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(800, 32);
            this.toolbox.TabIndex = 2;
            this.toolbox.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            this.btnInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInserir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Padding = new System.Windows.Forms.Padding(5);
            this.btnInserir.Size = new System.Drawing.Size(72, 29);
            this.btnInserir.Text = "Adicionar";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditar.Size = new System.Drawing.Size(51, 29);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Size = new System.Drawing.Size(56, 29);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(41, 29);
            this.btnFiltrar.Text = "Filtrar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // labelTipoCadastro
            // 
            this.labelTipoCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTipoCadastro.Name = "labelTipoCadastro";
            this.labelTipoCadastro.Size = new System.Drawing.Size(90, 29);
            this.labelTipoCadastro.Text = "[tipoCadastro]";
            // 
            // panelRegistros
            // 
            this.panelRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistros.Location = new System.Drawing.Point(0, 56);
            this.panelRegistros.Name = "panelRegistros";
            this.panelRegistros.Size = new System.Drawing.Size(800, 394);
            this.panelRegistros.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelRodape});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            this.labelRodape.Name = "labelRodape";
            this.labelRodape.Size = new System.Drawing.Size(52, 17);
            this.labelRodape.Text = "[rodapé]";
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelRegistros);
            this.Controls.Add(this.toolbox);
            this.Controls.Add(this.menu);
            this.Name = "TelaPrincipalForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locadora de Veículos Top";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.toolbox.ResumeLayout(false);
            this.toolbox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem disciplinaMenuItem;
        private ToolStrip toolbox;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel labelTipoCadastro;
        private Panel panelRegistros;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelRodape;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripMenuItem grupoDeAutomóvelToolStripMenuItem;
        private ToolStripMenuItem clienteMenuItem;
        private ToolStripMenuItem condutorToolStripMenuItem;
        private ToolStripMenuItem planoECobrançaToolStripMenuItem;
        private ToolStripMenuItem taxaEServiçoToolStripMenuItem;
        private ToolStripMenuItem aluguelToolStripMenuItem;
        private ToolStripMenuItem automóvelToolStripMenuItem;
        private ToolStripMenuItem cupomToolStripMenuItem;
        private ToolStripButton btnFiltrar;
        private ToolStripMenuItem configuraçãoDePreçosToolStripMenuItem;
    }
}