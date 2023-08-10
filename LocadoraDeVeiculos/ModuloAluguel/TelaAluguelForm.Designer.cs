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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGrupoAutomovel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPlanoCobranca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataLocacao = new System.Windows.Forms.DateTimePicker();
            this.cmbCondutor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAutomovel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKmAutomovel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDataDevolucaoPrevista = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCupom = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.listTaxasSelecionadas = new System.Windows.Forms.CheckedListBox();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.listTaxasAdicionais = new System.Windows.Forms.CheckedListBox();
            this.btnAplicarCupom = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tp1.SuspendLayout();
            this.tp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(697, 519);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 61);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(600, 519);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 61);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Funcionário:";
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(152, 42);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(258, 23);
            this.cmbFuncionario.TabIndex = 7;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(152, 71);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(258, 23);
            this.cmbCliente.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cliente:";
            // 
            // cmbGrupoAutomovel
            // 
            this.cmbGrupoAutomovel.FormattingEnabled = true;
            this.cmbGrupoAutomovel.Location = new System.Drawing.Point(152, 100);
            this.cmbGrupoAutomovel.Name = "cmbGrupoAutomovel";
            this.cmbGrupoAutomovel.Size = new System.Drawing.Size(258, 23);
            this.cmbGrupoAutomovel.TabIndex = 11;
            this.cmbGrupoAutomovel.SelectedIndexChanged += new System.EventHandler(this.cmbGrupoAutomovel_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grupo de Automóveis:";
            // 
            // cmbPlanoCobranca
            // 
            this.cmbPlanoCobranca.FormattingEnabled = true;
            this.cmbPlanoCobranca.Location = new System.Drawing.Point(152, 129);
            this.cmbPlanoCobranca.Name = "cmbPlanoCobranca";
            this.cmbPlanoCobranca.Size = new System.Drawing.Size(258, 23);
            this.cmbPlanoCobranca.TabIndex = 13;
            this.cmbPlanoCobranca.SelectedIndexChanged += new System.EventHandler(this.cmbPlanoCobranca_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Plano de Cobrança:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Data Locação:";
            // 
            // txtDataLocacao
            // 
            this.txtDataLocacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataLocacao.Location = new System.Drawing.Point(152, 158);
            this.txtDataLocacao.MinDate = new System.DateTime(2023, 8, 9, 0, 0, 0, 0);
            this.txtDataLocacao.Name = "txtDataLocacao";
            this.txtDataLocacao.Size = new System.Drawing.Size(258, 23);
            this.txtDataLocacao.TabIndex = 15;
            this.txtDataLocacao.ValueChanged += new System.EventHandler(this.txtDataLocacao_ValueChanged);
            // 
            // cmbCondutor
            // 
            this.cmbCondutor.FormattingEnabled = true;
            this.cmbCondutor.Location = new System.Drawing.Point(530, 71);
            this.cmbCondutor.Name = "cmbCondutor";
            this.cmbCondutor.Size = new System.Drawing.Size(258, 23);
            this.cmbCondutor.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Condutor:";
            // 
            // cmbAutomovel
            // 
            this.cmbAutomovel.FormattingEnabled = true;
            this.cmbAutomovel.Location = new System.Drawing.Point(530, 100);
            this.cmbAutomovel.Name = "cmbAutomovel";
            this.cmbAutomovel.Size = new System.Drawing.Size(258, 23);
            this.cmbAutomovel.TabIndex = 19;
            this.cmbAutomovel.SelectedIndexChanged += new System.EventHandler(this.cmbAutomovel_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Automóvel:";
            // 
            // txtKmAutomovel
            // 
            this.txtKmAutomovel.Location = new System.Drawing.Point(530, 129);
            this.txtKmAutomovel.Name = "txtKmAutomovel";
            this.txtKmAutomovel.ReadOnly = true;
            this.txtKmAutomovel.Size = new System.Drawing.Size(258, 23);
            this.txtKmAutomovel.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Km de Automóvel:";
            // 
            // txtDataDevolucaoPrevista
            // 
            this.txtDataDevolucaoPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataDevolucaoPrevista.Location = new System.Drawing.Point(530, 158);
            this.txtDataDevolucaoPrevista.MinDate = new System.DateTime(2023, 8, 9, 0, 0, 0, 0);
            this.txtDataDevolucaoPrevista.Name = "txtDataDevolucaoPrevista";
            this.txtDataDevolucaoPrevista.Size = new System.Drawing.Size(258, 23);
            this.txtDataDevolucaoPrevista.TabIndex = 23;
            this.txtDataDevolucaoPrevista.ValueChanged += new System.EventHandler(this.txtDataDevolucaoPrevista_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Devolução Prevista:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(96, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Cupom:";
            // 
            // txtCupom
            // 
            this.txtCupom.Location = new System.Drawing.Point(152, 187);
            this.txtCupom.Name = "txtCupom";
            this.txtCupom.Size = new System.Drawing.Size(258, 23);
            this.txtCupom.TabIndex = 24;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tp1);
            this.tabControl.Controls.Add(this.tp2);
            this.tabControl.Location = new System.Drawing.Point(20, 216);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(768, 297);
            this.tabControl.TabIndex = 26;
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.listTaxasSelecionadas);
            this.tp1.Location = new System.Drawing.Point(4, 24);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(760, 269);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Taxas Selecionadas";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // listTaxasSelecionadas
            // 
            this.listTaxasSelecionadas.CheckOnClick = true;
            this.listTaxasSelecionadas.FormattingEnabled = true;
            this.listTaxasSelecionadas.Location = new System.Drawing.Point(6, 6);
            this.listTaxasSelecionadas.Name = "listTaxasSelecionadas";
            this.listTaxasSelecionadas.Size = new System.Drawing.Size(748, 256);
            this.listTaxasSelecionadas.TabIndex = 0;
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.listTaxasAdicionais);
            this.tp2.Location = new System.Drawing.Point(4, 24);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(760, 269);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "Taxas Adicionais";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // listTaxasAdicionais
            // 
            this.listTaxasAdicionais.FormattingEnabled = true;
            this.listTaxasAdicionais.Location = new System.Drawing.Point(6, 5);
            this.listTaxasAdicionais.Name = "listTaxasAdicionais";
            this.listTaxasAdicionais.Size = new System.Drawing.Size(748, 256);
            this.listTaxasAdicionais.TabIndex = 0;
            // 
            // btnAplicarCupom
            // 
            this.btnAplicarCupom.Location = new System.Drawing.Point(418, 187);
            this.btnAplicarCupom.Name = "btnAplicarCupom";
            this.btnAplicarCupom.Size = new System.Drawing.Size(106, 23);
            this.btnAplicarCupom.TabIndex = 27;
            this.btnAplicarCupom.Text = "Aplicar Cupom";
            this.btnAplicarCupom.UseVisualStyleBackColor = true;
            this.btnAplicarCupom.Click += new System.EventHandler(this.btnAplicarCupom_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 542);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Valor Total Previsto: R$";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.AutoSize = true;
            this.txtValorTotal.ForeColor = System.Drawing.Color.Green;
            this.txtValorTotal.Location = new System.Drawing.Point(152, 542);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(13, 15);
            this.txtValorTotal.TabIndex = 29;
            this.txtValorTotal.Text = "0";
            // 
            // TelaAluguelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAplicarCupom);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCupom);
            this.Controls.Add(this.txtDataDevolucaoPrevista);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKmAutomovel);
            this.Controls.Add(this.cmbAutomovel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCondutor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDataLocacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbPlanoCobranca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbGrupoAutomovel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "TelaAluguelForm";
            this.Text = "Cadastro de Aluguel";
            this.tabControl.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DateTimePicker txtDataDevolucaoPrevista;
        private Label label9;
        private Label label10;
        private TextBox txtCupom;
        private TabControl tabControl;
        private TabPage tp1;
        private CheckedListBox listTaxasSelecionadas;
        private TabPage tp2;
        private CheckedListBox listTaxasAdicionais;
        private Button btnAplicarCupom;
        private Label label11;
        private Label txtValorTotal;
    }
}