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
            menu = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            disciplinaMenuItem = new ToolStripMenuItem();
            grupoDeAutomoveisMenuItem = new ToolStripMenuItem();
            toolbox = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            labelTipoCadastro = new ToolStripLabel();
            panelRegistros = new Panel();
            statusStrip1 = new StatusStrip();
            labelRodape = new ToolStripStatusLabel();
            menu.SuspendLayout();
            toolbox.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(800, 24);
            menu.TabIndex = 1;
            menu.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disciplinaMenuItem, grupoDeAutomoveisMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // disciplinaMenuItem
            // 
            disciplinaMenuItem.Name = "disciplinaMenuItem";
            disciplinaMenuItem.ShortcutKeys = Keys.F1;
            disciplinaMenuItem.Size = new Size(209, 22);
            disciplinaMenuItem.Text = "Parceiro";
            disciplinaMenuItem.Click += disciplinaMenuItem_Click;
            // 
            // grupoDeAutomoveisMenuItem
            // 
            grupoDeAutomoveisMenuItem.Name = "grupoDeAutomoveisMenuItem";
            grupoDeAutomoveisMenuItem.ShortcutKeys = Keys.F2;
            grupoDeAutomoveisMenuItem.Size = new Size(209, 22);
            grupoDeAutomoveisMenuItem.Text = "Grupo de Automóveis";
            grupoDeAutomoveisMenuItem.Click += grupoDeAutomoveisMenuItem_Click;
            // 
            // toolbox
            // 
            toolbox.Enabled = false;
            toolbox.ImageScalingSize = new Size(20, 20);
            toolbox.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator2, labelTipoCadastro });
            toolbox.Location = new Point(0, 24);
            toolbox.Name = "toolbox";
            toolbox.Size = new Size(800, 32);
            toolbox.TabIndex = 2;
            toolbox.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnInserir.ImageScaling = ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(5);
            btnInserir.Size = new Size(72, 29);
            btnInserir.Text = "Adicionar";
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5);
            btnEditar.Size = new Size(51, 29);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(5);
            btnExcluir.Size = new Size(56, 29);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 32);
            // 
            // labelTipoCadastro
            // 
            labelTipoCadastro.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelTipoCadastro.Name = "labelTipoCadastro";
            labelTipoCadastro.Size = new Size(90, 29);
            labelTipoCadastro.Text = "[tipoCadastro]";
            // 
            // panelRegistros
            // 
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 56);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(800, 394);
            panelRegistros.TabIndex = 4;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelRodape });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            labelRodape.Name = "labelRodape";
            labelRodape.Size = new Size(52, 17);
            labelRodape.Text = "[rodapé]";
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(panelRegistros);
            Controls.Add(toolbox);
            Controls.Add(menu);
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Locadora de Veículos Top";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            toolbox.ResumeLayout(false);
            toolbox.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private ToolStripMenuItem grupoDeAutomoveisMenuItem;
    }
}