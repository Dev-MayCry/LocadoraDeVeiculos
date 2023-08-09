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
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            cmbGrupoAutomoveis = new ComboBox();
            groupBox1 = new GroupBox();
            txtKmDisponiveis = new TextBox();
            label5 = new Label();
            txtPrecoKm = new TextBox();
            label4 = new Label();
            txtPrecoDiaria = new TextBox();
            cmbNomesPlanos = new ComboBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 72);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 18;
            label1.Text = "Preço Diária:";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(438, 293);
            button2.Name = "button2";
            button2.Size = new Size(91, 61);
            button2.TabIndex = 17;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(341, 293);
            button1.Name = "button1";
            button1.Size = new Size(91, 61);
            button1.TabIndex = 16;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGravar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 24);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 24;
            label2.Text = "Grupo de Automóveis: ";
            // 
            // cmbGrupoAutomoveis
            // 
            cmbGrupoAutomoveis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrupoAutomoveis.FormattingEnabled = true;
            cmbGrupoAutomoveis.Location = new Point(170, 21);
            cmbGrupoAutomoveis.Name = "cmbGrupoAutomoveis";
            cmbGrupoAutomoveis.Size = new Size(338, 23);
            cmbGrupoAutomoveis.TabIndex = 25;
            cmbGrupoAutomoveis.SelectedIndexChanged += cmbGrupoAutomoveis_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtKmDisponiveis);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPrecoKm);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPrecoDiaria);
            groupBox1.Controls.Add(cmbNomesPlanos);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(35, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 197);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configuração de Planos";
            // 
            // txtKmDisponiveis
            // 
            txtKmDisponiveis.Location = new Point(161, 133);
            txtKmDisponiveis.Name = "txtKmDisponiveis";
            txtKmDisponiveis.Size = new Size(280, 23);
            txtKmDisponiveis.TabIndex = 31;
            txtKmDisponiveis.TextChanged += txtKmDisponiveis_TextChanged;
            txtKmDisponiveis.KeyPress += txtKmDisponiveis_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 133);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 30;
            label5.Text = "Km Disponíveis: ";
            // 
            // txtPrecoKm
            // 
            txtPrecoKm.Location = new Point(161, 101);
            txtPrecoKm.Name = "txtPrecoKm";
            txtPrecoKm.Size = new Size(280, 23);
            txtPrecoKm.TabIndex = 29;
            txtPrecoKm.TextChanged += txtPrecoKm_TextChanged;
            txtPrecoKm.KeyPress += txtPrecoKm_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 104);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 28;
            label4.Text = "Preço por Km: ";
            // 
            // txtPrecoDiaria
            // 
            txtPrecoDiaria.Location = new Point(161, 72);
            txtPrecoDiaria.Name = "txtPrecoDiaria";
            txtPrecoDiaria.Size = new Size(280, 23);
            txtPrecoDiaria.TabIndex = 27;
            txtPrecoDiaria.TextChanged += txtPrecoDiaria_TextChanged;
            txtPrecoDiaria.KeyPress += txtPrecoDiaria_KeyPress;
            // 
            // cmbNomesPlanos
            // 
            cmbNomesPlanos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNomesPlanos.FormattingEnabled = true;
            cmbNomesPlanos.Location = new Point(161, 44);
            cmbNomesPlanos.Name = "cmbNomesPlanos";
            cmbNomesPlanos.Size = new Size(280, 23);
            cmbNomesPlanos.TabIndex = 26;
            cmbNomesPlanos.SelectedIndexChanged += cmbNomesPlanos_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 44);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 25;
            label3.Text = "Tipo do Plano: ";
            // 
            // TelaPlanoCobrancaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 366);
            Controls.Add(groupBox1);
            Controls.Add(cmbGrupoAutomoveis);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "TelaPlanoCobrancaForm";
            Text = "Cadastro de Plano de Cobrança";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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