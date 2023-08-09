namespace LocadoraDeVeiculos.WinApp.ModuloAluguel {
    partial class TelaAluguelForm {
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
            btnCancelar = new Button();
            btnSalvar = new Button();
            label1 = new Label();
            cmbFuncionario = new ComboBox();
            cmbCliente = new ComboBox();
            label2 = new Label();
            cmbGrupoAutomovel = new ComboBox();
            label3 = new Label();
            cmbPlanoCobranca = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txtDataLocacao = new DateTimePicker();
            cmbCondutor = new ComboBox();
            label6 = new Label();
            cmbAutomovel = new ComboBox();
            label7 = new Label();
            txtKmAutomovel = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(697, 377);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 61);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(600, 377);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(91, 61);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 46);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 6;
            label1.Text = "Funcionário:";
            // 
            // cmbFuncionario
            // 
            cmbFuncionario.FormattingEnabled = true;
            cmbFuncionario.Location = new Point(152, 42);
            cmbFuncionario.Name = "cmbFuncionario";
            cmbFuncionario.Size = new Size(258, 23);
            cmbFuncionario.TabIndex = 7;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(152, 71);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(258, 23);
            cmbCliente.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 75);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 8;
            label2.Text = "Cliente:";
            // 
            // cmbGrupoAutomovel
            // 
            cmbGrupoAutomovel.FormattingEnabled = true;
            cmbGrupoAutomovel.Location = new Point(152, 100);
            cmbGrupoAutomovel.Name = "cmbGrupoAutomovel";
            cmbGrupoAutomovel.Size = new Size(258, 23);
            cmbGrupoAutomovel.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 104);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 10;
            label3.Text = "Grupo de Automóveis:";
            // 
            // cmbPlanoCobranca
            // 
            cmbPlanoCobranca.FormattingEnabled = true;
            cmbPlanoCobranca.Location = new Point(152, 129);
            cmbPlanoCobranca.Name = "cmbPlanoCobranca";
            cmbPlanoCobranca.Size = new Size(258, 23);
            cmbPlanoCobranca.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 133);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 12;
            label4.Text = "Plano de Cobrança:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 162);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 14;
            label5.Text = "Data Locação:";
            // 
            // txtDataLocacao
            // 
            txtDataLocacao.Format = DateTimePickerFormat.Short;
            txtDataLocacao.Location = new Point(152, 158);
            txtDataLocacao.Name = "txtDataLocacao";
            txtDataLocacao.Size = new Size(258, 23);
            txtDataLocacao.TabIndex = 15;
            // 
            // cmbCondutor
            // 
            cmbCondutor.FormattingEnabled = true;
            cmbCondutor.Location = new Point(530, 71);
            cmbCondutor.Name = "cmbCondutor";
            cmbCondutor.Size = new Size(258, 23);
            cmbCondutor.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(463, 75);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 16;
            label6.Text = "Condutor:";
            // 
            // cmbAutomovel
            // 
            cmbAutomovel.FormattingEnabled = true;
            cmbAutomovel.Location = new Point(530, 100);
            cmbAutomovel.Name = "cmbAutomovel";
            cmbAutomovel.Size = new Size(258, 23);
            cmbAutomovel.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(455, 104);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 18;
            label7.Text = "Automóvel:";
            // 
            // txtKmAutomovel
            // 
            txtKmAutomovel.Location = new Point(530, 129);
            txtKmAutomovel.Name = "txtKmAutomovel";
            txtKmAutomovel.Size = new Size(258, 23);
            txtKmAutomovel.TabIndex = 20;
            txtKmAutomovel.KeyPress += txtKmAutomovel_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(418, 133);
            label8.Name = "label8";
            label8.Size = new Size(106, 15);
            label8.TabIndex = 21;
            label8.Text = "Km de Automóvel:";
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(txtKmAutomovel);
            Controls.Add(cmbAutomovel);
            Controls.Add(label7);
            Controls.Add(cmbCondutor);
            Controls.Add(label6);
            Controls.Add(txtDataLocacao);
            Controls.Add(label5);
            Controls.Add(cmbPlanoCobranca);
            Controls.Add(label4);
            Controls.Add(cmbGrupoAutomovel);
            Controls.Add(label3);
            Controls.Add(cmbCliente);
            Controls.Add(label2);
            Controls.Add(cmbFuncionario);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Name = "TelaAluguelForm";
            Text = "Cadastro de Aluguel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnSalvar;
        private Label label1;
        private ComboBox cmbFuncionario;
        private ComboBox cmbCliente;
        private Label label2;
        private ComboBox cmbGrupoAutomovel;
        private Label label3;
        private ComboBox cmbPlanoCobranca;
        private Label label4;
        private Label label5;
        private DateTimePicker txtDataLocacao;
        private ComboBox cmbCondutor;
        private Label label6;
        private ComboBox cmbAutomovel;
        private Label label7;
        private TextBox txtKmAutomovel;
        private Label label8;
    }
}