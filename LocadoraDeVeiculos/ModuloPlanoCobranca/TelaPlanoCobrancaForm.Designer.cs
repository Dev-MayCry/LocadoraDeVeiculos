namespace LocadoraDeVeiculos.WinApp.ModuloPlanoCobranca {
    partial class TelaPlanoCobrancaForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGrupoAutomoveis = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKmDisponiveis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecoKm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecoDiaria = new System.Windows.Forms.TextBox();
            this.cmbNomesPlanos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Preço Diária:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(438, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 61);
            this.button2.TabIndex = 17;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(341, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 61);
            this.button1.TabIndex = 16;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Grupo de Automóveis: ";
            // 
            // cmbGrupoAutomoveis
            // 
            this.cmbGrupoAutomoveis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupoAutomoveis.FormattingEnabled = true;
            this.cmbGrupoAutomoveis.Location = new System.Drawing.Point(170, 21);
            this.cmbGrupoAutomoveis.Name = "cmbGrupoAutomoveis";
            this.cmbGrupoAutomoveis.Size = new System.Drawing.Size(338, 23);
            this.cmbGrupoAutomoveis.TabIndex = 25;
            this.cmbGrupoAutomoveis.SelectedIndexChanged += new System.EventHandler(this.cmbGrupoAutomoveis_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKmDisponiveis);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPrecoKm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrecoDiaria);
            this.groupBox1.Controls.Add(this.cmbNomesPlanos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 197);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração de Planos";
            // 
            // txtKmDisponiveis
            // 
            this.txtKmDisponiveis.Location = new System.Drawing.Point(161, 133);
            this.txtKmDisponiveis.Name = "txtKmDisponiveis";
            this.txtKmDisponiveis.Size = new System.Drawing.Size(280, 23);
            this.txtKmDisponiveis.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Km Disponíveis: ";
            // 
            // txtPrecoKm
            // 
            this.txtPrecoKm.Location = new System.Drawing.Point(161, 101);
            this.txtPrecoKm.Name = "txtPrecoKm";
            this.txtPrecoKm.Size = new System.Drawing.Size(280, 23);
            this.txtPrecoKm.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Preço por Km: ";
            // 
            // txtPrecoDiaria
            // 
            this.txtPrecoDiaria.Location = new System.Drawing.Point(161, 72);
            this.txtPrecoDiaria.Name = "txtPrecoDiaria";
            this.txtPrecoDiaria.Size = new System.Drawing.Size(280, 23);
            this.txtPrecoDiaria.TabIndex = 27;
            // 
            // cmbNomesPlanos
            // 
            this.cmbNomesPlanos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomesPlanos.FormattingEnabled = true;
            this.cmbNomesPlanos.Location = new System.Drawing.Point(161, 44);
            this.cmbNomesPlanos.Name = "cmbNomesPlanos";
            this.cmbNomesPlanos.Size = new System.Drawing.Size(280, 23);
            this.cmbNomesPlanos.TabIndex = 26;
            this.cmbNomesPlanos.SelectedIndexChanged += new System.EventHandler(this.cmbNomesPlanos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tipo do Plano: ";
            // 
            // TelaPlanoCobrancaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbGrupoAutomoveis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "TelaPlanoCobrancaForm";
            this.Text = "Cadastro de Plano de Cobrança";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label2;
        private ComboBox cmbGrupoAutomoveis;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox txtPrecoKm;
        private Label label4;
        private TextBox txtPrecoDiaria;
        private ComboBox cmbNomesPlanos;
        private Label label3;
        private TextBox txtKmDisponiveis;
    }
}