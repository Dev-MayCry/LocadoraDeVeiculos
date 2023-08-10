namespace LocadoraDeVeiculos.WinApp.ModuloAluguel {
    partial class TelaDevolucaoAluguelForm {
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
            this.txtValorTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.listTaxasSelecionadas = new System.Windows.Forms.CheckedListBox();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.listTaxasAdicionais = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCupom = new System.Windows.Forms.TextBox();
            this.txtDataDevolucaoPrevista = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKmAutomovel = new System.Windows.Forms.TextBox();
            this.cmbAutomovel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCondutor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDataLocacao = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPlanoCobranca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGrupoAutomovel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbNivelTanque = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtKmPercorrida = new System.Windows.Forms.NumericUpDown();
            this.tabControl.SuspendLayout();
            this.tp1.SuspendLayout();
            this.tp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKmPercorrida)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.AutoSize = true;
            this.txtValorTotal.ForeColor = System.Drawing.Color.Green;
            this.txtValorTotal.Location = new System.Drawing.Point(139, 614);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(13, 15);
            this.txtValorTotal.TabIndex = 55;
            this.txtValorTotal.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 614);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 15);
            this.label11.TabIndex = 54;
            this.label11.Text = "Valor Total Previsto: R$";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tp1);
            this.tabControl.Controls.Add(this.tp2);
            this.tabControl.Location = new System.Drawing.Point(13, 285);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(768, 297);
            this.tabControl.TabIndex = 52;
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
            this.listTaxasAdicionais.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listTaxasAdicionais_ItemCheck);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 51;
            this.label10.Text = "Cupom:";
            // 
            // txtCupom
            // 
            this.txtCupom.Location = new System.Drawing.Point(145, 182);
            this.txtCupom.Name = "txtCupom";
            this.txtCupom.Size = new System.Drawing.Size(258, 23);
            this.txtCupom.TabIndex = 50;
            // 
            // txtDataDevolucaoPrevista
            // 
            this.txtDataDevolucaoPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataDevolucaoPrevista.Location = new System.Drawing.Point(523, 153);
            this.txtDataDevolucaoPrevista.MinDate = new System.DateTime(2023, 8, 9, 0, 0, 0, 0);
            this.txtDataDevolucaoPrevista.Name = "txtDataDevolucaoPrevista";
            this.txtDataDevolucaoPrevista.Size = new System.Drawing.Size(258, 23);
            this.txtDataDevolucaoPrevista.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 15);
            this.label9.TabIndex = 48;
            this.label9.Text = "Devolução Prevista:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(411, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 47;
            this.label8.Text = "Km de Automóvel:";
            // 
            // txtKmAutomovel
            // 
            this.txtKmAutomovel.Location = new System.Drawing.Point(523, 124);
            this.txtKmAutomovel.Name = "txtKmAutomovel";
            this.txtKmAutomovel.Size = new System.Drawing.Size(258, 23);
            this.txtKmAutomovel.TabIndex = 46;
            // 
            // cmbAutomovel
            // 
            this.cmbAutomovel.FormattingEnabled = true;
            this.cmbAutomovel.Location = new System.Drawing.Point(523, 95);
            this.cmbAutomovel.Name = "cmbAutomovel";
            this.cmbAutomovel.Size = new System.Drawing.Size(258, 23);
            this.cmbAutomovel.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "Automóvel:";
            // 
            // cmbCondutor
            // 
            this.cmbCondutor.FormattingEnabled = true;
            this.cmbCondutor.Location = new System.Drawing.Point(523, 66);
            this.cmbCondutor.Name = "cmbCondutor";
            this.cmbCondutor.Size = new System.Drawing.Size(258, 23);
            this.cmbCondutor.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Condutor:";
            // 
            // txtDataLocacao
            // 
            this.txtDataLocacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataLocacao.Location = new System.Drawing.Point(145, 153);
            this.txtDataLocacao.MinDate = new System.DateTime(2023, 8, 9, 0, 0, 0, 0);
            this.txtDataLocacao.Name = "txtDataLocacao";
            this.txtDataLocacao.Size = new System.Drawing.Size(258, 23);
            this.txtDataLocacao.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "Data Locação:";
            // 
            // cmbPlanoCobranca
            // 
            this.cmbPlanoCobranca.FormattingEnabled = true;
            this.cmbPlanoCobranca.Location = new System.Drawing.Point(145, 124);
            this.cmbPlanoCobranca.Name = "cmbPlanoCobranca";
            this.cmbPlanoCobranca.Size = new System.Drawing.Size(258, 23);
            this.cmbPlanoCobranca.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Plano de Cobrança:";
            // 
            // cmbGrupoAutomovel
            // 
            this.cmbGrupoAutomovel.FormattingEnabled = true;
            this.cmbGrupoAutomovel.Location = new System.Drawing.Point(145, 95);
            this.cmbGrupoAutomovel.Name = "cmbGrupoAutomovel";
            this.cmbGrupoAutomovel.Size = new System.Drawing.Size(258, 23);
            this.cmbGrupoAutomovel.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Grupo de Automóveis:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(145, 66);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(258, 23);
            this.cmbCliente.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Cliente:";
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(145, 37);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(258, 23);
            this.cmbFuncionario.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Funcionário:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(697, 591);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 61);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(600, 591);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 61);
            this.btnSalvar.TabIndex = 30;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtDataDevolucao
            // 
            this.txtDataDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataDevolucao.Location = new System.Drawing.Point(145, 211);
            this.txtDataDevolucao.MinDate = new System.DateTime(2023, 8, 9, 0, 0, 0, 0);
            this.txtDataDevolucao.Name = "txtDataDevolucao";
            this.txtDataDevolucao.Size = new System.Drawing.Size(258, 23);
            this.txtDataDevolucao.TabIndex = 57;
            this.txtDataDevolucao.Value = new System.DateTime(2023, 8, 9, 21, 49, 12, 0);
            this.txtDataDevolucao.ValueChanged += new System.EventHandler(this.txtDataDevolucao_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 15);
            this.label12.TabIndex = 56;
            this.label12.Text = "Data Devolução:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(432, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 15);
            this.label13.TabIndex = 59;
            this.label13.Text = "Km Percorrida:";
            // 
            // cmbNivelTanque
            // 
            this.cmbNivelTanque.FormattingEnabled = true;
            this.cmbNivelTanque.Location = new System.Drawing.Point(145, 240);
            this.cmbNivelTanque.Name = "cmbNivelTanque";
            this.cmbNivelTanque.Size = new System.Drawing.Size(258, 23);
            this.cmbNivelTanque.TabIndex = 61;
            this.cmbNivelTanque.SelectedIndexChanged += new System.EventHandler(this.cmbNivelTanque_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 15);
            this.label14.TabIndex = 60;
            this.label14.Text = "Nível do Tanque:";
            // 
            // txtKmPercorrida
            // 
            this.txtKmPercorrida.Location = new System.Drawing.Point(523, 213);
            this.txtKmPercorrida.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.txtKmPercorrida.Name = "txtKmPercorrida";
            this.txtKmPercorrida.Size = new System.Drawing.Size(254, 23);
            this.txtKmPercorrida.TabIndex = 62;
            this.txtKmPercorrida.ValueChanged += new System.EventHandler(this.txtKmPercorrida_TextChanged);
            // 
            // TelaDevolucaoAluguelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.txtKmPercorrida);
            this.Controls.Add(this.cmbNivelTanque);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDataDevolucao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label11);
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
            this.Enabled = false;
            this.Name = "TelaDevolucaoAluguelForm";
            this.Text = "TelaDevolucaoAluguelForm";
            this.tabControl.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtKmPercorrida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtValorTotal;
        private Label label11;
        private TabControl tabControl;
        private TabPage tp1;
        private CheckedListBox listTaxasSelecionadas;
        private TabPage tp2;
        private CheckedListBox listTaxasAdicionais;
        private Label label10;
        private TextBox txtCupom;
        private DateTimePicker txtDataDevolucaoPrevista;
        private Label label9;
        private Label label8;
        private TextBox txtKmAutomovel;
        private ComboBox cmbAutomovel;
        private Label label7;
        private ComboBox cmbCondutor;
        private Label label6;
        private DateTimePicker txtDataLocacao;
        private Label label5;
        private ComboBox cmbPlanoCobranca;
        private Label label4;
        private ComboBox cmbGrupoAutomovel;
        private Label label3;
        private ComboBox cmbCliente;
        private Label label2;
        private ComboBox cmbFuncionario;
        private Label label1;
        private Button btnCancelar;
        private Button btnSalvar;
        private DateTimePicker txtDataDevolucao;
        private Label label12;
        private Label label13;
        private ComboBox cmbNivelTanque;
        private Label label14;
        private NumericUpDown txtKmPercorrida;
    }
}