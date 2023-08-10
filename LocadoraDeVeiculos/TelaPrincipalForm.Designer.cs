namespace LocadoraDeVeiculos {
    partial class TelaPrincipalForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aluguelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automóvelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cupomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoDeAutomóvelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planoECobrançaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxaEServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbox = new System.Windows.Forms.ToolStrip();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnFiltrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfigurar = new System.Windows.Forms.ToolStripButton();
            this.btnEncerrar = new System.Windows.Forms.ToolStripButton();
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
            this.menu.Size = new System.Drawing.Size(1264, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aluguelToolStripMenuItem,
            this.automóvelToolStripMenuItem,
            this.clienteMenuItem,
            this.cupomToolStripMenuItem,
            this.condutorToolStripMenuItem,
            this.funcionárioToolStripMenuItem,
            this.grupoDeAutomóvelToolStripMenuItem,
            this.disciplinaMenuItem,
            this.planoECobrançaToolStripMenuItem,
            this.taxaEServiçoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // aluguelToolStripMenuItem
            // 
            this.aluguelToolStripMenuItem.Name = "aluguelToolStripMenuItem";
            this.aluguelToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aluguelToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.aluguelToolStripMenuItem.Text = "Aluguel";
            this.aluguelToolStripMenuItem.Click += new System.EventHandler(this.aluguelToolStripMenuItem_Click);
            // 
            // automóvelToolStripMenuItem
            // 
            this.automóvelToolStripMenuItem.Name = "automóvelToolStripMenuItem";
            this.automóvelToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.automóvelToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.automóvelToolStripMenuItem.Text = "Automóvel";
            this.automóvelToolStripMenuItem.Click += new System.EventHandler(this.automóvelToolStripMenuItem_Click);
            // 
            // clienteMenuItem
            // 
            this.clienteMenuItem.Name = "clienteMenuItem";
            this.clienteMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.clienteMenuItem.Size = new System.Drawing.Size(204, 22);
            this.clienteMenuItem.Text = "Cliente";
            this.clienteMenuItem.Click += new System.EventHandler(this.clienteMenuItem_Click);
            // 
            // cupomToolStripMenuItem
            // 
            this.cupomToolStripMenuItem.Name = "cupomToolStripMenuItem";
            this.cupomToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.cupomToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.cupomToolStripMenuItem.Text = "Cupom";
            this.cupomToolStripMenuItem.Click += new System.EventHandler(this.cupomToolStripMenuItem_Click);
            // 
            // condutorToolStripMenuItem
            // 
            this.condutorToolStripMenuItem.Name = "condutorToolStripMenuItem";
            this.condutorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.condutorToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.condutorToolStripMenuItem.Text = "Condutor";
            this.condutorToolStripMenuItem.Click += new System.EventHandler(this.condutorToolStripMenuItem_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // grupoDeAutomóvelToolStripMenuItem
            // 
            this.grupoDeAutomóvelToolStripMenuItem.Name = "grupoDeAutomóvelToolStripMenuItem";
            this.grupoDeAutomóvelToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.grupoDeAutomóvelToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.grupoDeAutomóvelToolStripMenuItem.Text = "Grupo de Automóvel";
            this.grupoDeAutomóvelToolStripMenuItem.Click += new System.EventHandler(this.grupoDeAutomoveisMenuItem_Click);
            // 
            // disciplinaMenuItem
            // 
            this.disciplinaMenuItem.Name = "disciplinaMenuItem";
            this.disciplinaMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.disciplinaMenuItem.Size = new System.Drawing.Size(204, 22);
            this.disciplinaMenuItem.Text = "Parceiro";
            this.disciplinaMenuItem.Click += new System.EventHandler(this.disciplinaMenuItem_Click);
            // 
            // planoECobrançaToolStripMenuItem
            // 
            this.planoECobrançaToolStripMenuItem.Name = "planoECobrançaToolStripMenuItem";
            this.planoECobrançaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.planoECobrançaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.planoECobrançaToolStripMenuItem.Text = "Plano e Cobrança";
            this.planoECobrançaToolStripMenuItem.Click += new System.EventHandler(this.planoECobrançaToolStripMenuItem_Click);
            // 
            // taxaEServiçoToolStripMenuItem
            // 
            this.taxaEServiçoToolStripMenuItem.Name = "taxaEServiçoToolStripMenuItem";
            this.taxaEServiçoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.taxaEServiçoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.taxaEServiçoToolStripMenuItem.Text = "Taxa e Serviço";
            this.taxaEServiçoToolStripMenuItem.Click += new System.EventHandler(this.taxaEServiçoToolStripMenuItem_Click);
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
            this.btnConfigurar,
            this.btnEncerrar,
            this.labelTipoCadastro});
            this.toolbox.Location = new System.Drawing.Point(0, 24);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(1264, 57);
            this.toolbox.TabIndex = 2;
            this.toolbox.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            this.btnInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInserir.Image = global::LocadoraDeVeiculos.WinApp.Properties.Resources.add_circle_FILL0_wght400_GRAD0_opsz40;
            this.btnInserir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Padding = new System.Windows.Forms.Padding(5);
            this.btnInserir.Size = new System.Drawing.Size(54, 54);
            this.btnInserir.Text = "Adicionar";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::LocadoraDeVeiculos.WinApp.Properties.Resources.edit_FILL0_wght400_GRAD0_opsz40;
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditar.Size = new System.Drawing.Size(54, 54);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = global::LocadoraDeVeiculos.WinApp.Properties.Resources.delete_FILL0_wght400_GRAD0_opsz40;
            this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Size = new System.Drawing.Size(54, 54);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFiltrar.Image = global::LocadoraDeVeiculos.WinApp.Properties.Resources.filter_alt_FILL0_wght400_GRAD0_opsz40;
            this.btnFiltrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(44, 54);
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConfigurar.Image = global::LocadoraDeVeiculos.WinApp.Properties.Resources.local_gas_station_FILL0_wght400_GRAD0_opsz40;
            this.btnConfigurar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConfigurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(44, 54);
            this.btnConfigurar.Text = "Configurar Preço";
            this.btnConfigurar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEncerrar.Image = global::LocadoraDeVeiculos.WinApp.Properties.Resources.task_alt_FILL0_wght400_GRAD0_opsz40;
            this.btnEncerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEncerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(44, 54);
            this.btnEncerrar.Text = "Encerrar Aluguel";
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // btnEncerrar
            // 
            btnEncerrar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnEncerrar.ImageTransparentColor = Color.Magenta;
            btnEncerrar.Name = "btnEncerrar";
            btnEncerrar.Size = new Size(98, 29);
            btnEncerrar.Text = "Encerrar Aluguel";
            btnEncerrar.Click += btnEncerrar_Click;
            // 
            // labelTipoCadastro
            // 
            this.labelTipoCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTipoCadastro.Name = "labelTipoCadastro";
            this.labelTipoCadastro.Size = new System.Drawing.Size(90, 54);
            this.labelTipoCadastro.Text = "[tipoCadastro]";
            // 
            // panelRegistros
            // 
            this.panelRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistros.Location = new System.Drawing.Point(0, 81);
            this.panelRegistros.Name = "panelRegistros";
            this.panelRegistros.Size = new System.Drawing.Size(1264, 600);
            this.panelRegistros.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelRodape});
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
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
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
        private ToolStripButton btnConfigurar;
        private ToolStripButton btnEncerrar;
    }
}