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
            txtValorTotal = new Label();
            label11 = new Label();
            tabControl = new TabControl();
            tp1 = new TabPage();
            listTaxasSelecionadas = new CheckedListBox();
            tp2 = new TabPage();
            listTaxasAdicionais = new CheckedListBox();
            label10 = new Label();
            txtCupom = new TextBox();
            txtDataDevolucaoPrevista = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            txtKmAutomovel = new TextBox();
            cmbAutomovel = new ComboBox();
            label7 = new Label();
            cmbCondutor = new ComboBox();
            label6 = new Label();
            txtDataLocacao = new DateTimePicker();
            label5 = new Label();
            cmbPlanoCobranca = new ComboBox();
            label4 = new Label();
            cmbGrupoAutomovel = new ComboBox();
            label3 = new Label();
            cmbCliente = new ComboBox();
            label2 = new Label();
            cmbFuncionario = new ComboBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            txtDataDevolucao = new DateTimePicker();
            label12 = new Label();
            label13 = new Label();
            txtKmPercorrida = new TextBox();
            cmbNivelTanque = new ComboBox();
            label14 = new Label();
            tabControl.SuspendLayout();
            tp1.SuspendLayout();
            tp2.SuspendLayout();
            SuspendLayout();
            // 
            // txtValorTotal
            // 
            txtValorTotal.AutoSize = true;
            txtValorTotal.ForeColor = Color.Green;
            txtValorTotal.Location = new Point(139, 614);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(13, 15);
            txtValorTotal.TabIndex = 55;
            txtValorTotal.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 614);
            label11.Name = "label11";
            label11.Size = new Size(125, 15);
            label11.TabIndex = 54;
            label11.Text = "Valor Total Previsto: R$";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tp1);
            tabControl.Controls.Add(tp2);
            tabControl.Location = new Point(13, 285);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(768, 297);
            tabControl.TabIndex = 52;
            // 
            // tp1
            // 
            tp1.Controls.Add(listTaxasSelecionadas);
            tp1.Location = new Point(4, 24);
            tp1.Name = "tp1";
            tp1.Padding = new Padding(3);
            tp1.Size = new Size(760, 269);
            tp1.TabIndex = 0;
            tp1.Text = "Taxas Selecionadas";
            tp1.UseVisualStyleBackColor = true;
            // 
            // listTaxasSelecionadas
            // 
            listTaxasSelecionadas.Enabled = false;
            listTaxasSelecionadas.FormattingEnabled = true;
            listTaxasSelecionadas.Location = new Point(6, 6);
            listTaxasSelecionadas.Name = "listTaxasSelecionadas";
            listTaxasSelecionadas.Size = new Size(748, 256);
            listTaxasSelecionadas.TabIndex = 0;
            // 
            // tp2
            // 
            tp2.Controls.Add(listTaxasAdicionais);
            tp2.Location = new Point(4, 24);
            tp2.Name = "tp2";
            tp2.Padding = new Padding(3);
            tp2.Size = new Size(760, 269);
            tp2.TabIndex = 1;
            tp2.Text = "Taxas Adicionais";
            tp2.UseVisualStyleBackColor = true;
            // 
            // listTaxasAdicionais
            // 
            listTaxasAdicionais.FormattingEnabled = true;
            listTaxasAdicionais.Location = new Point(6, 5);
            listTaxasAdicionais.Name = "listTaxasAdicionais";
            listTaxasAdicionais.Size = new Size(748, 256);
            listTaxasAdicionais.TabIndex = 0;
            listTaxasAdicionais.ItemCheck += listTaxasAdicionais_ItemCheck;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(89, 186);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 51;
            label10.Text = "Cupom:";
            // 
            // txtCupom
            // 
            txtCupom.Location = new Point(145, 182);
            txtCupom.Name = "txtCupom";
            txtCupom.Size = new Size(258, 23);
            txtCupom.TabIndex = 50;
            // 
            // txtDataDevolucaoPrevista
            // 
            txtDataDevolucaoPrevista.Enabled = false;
            txtDataDevolucaoPrevista.Format = DateTimePickerFormat.Short;
            txtDataDevolucaoPrevista.Location = new Point(523, 153);
            txtDataDevolucaoPrevista.MinDate = new DateTime(2023, 8, 9, 0, 0, 0, 0);
            txtDataDevolucaoPrevista.Name = "txtDataDevolucaoPrevista";
            txtDataDevolucaoPrevista.Size = new Size(258, 23);
            txtDataDevolucaoPrevista.TabIndex = 49;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(407, 157);
            label9.Name = "label9";
            label9.Size = new Size(110, 15);
            label9.TabIndex = 48;
            label9.Text = "Devolução Prevista:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(411, 128);
            label8.Name = "label8";
            label8.Size = new Size(106, 15);
            label8.TabIndex = 47;
            label8.Text = "Km de Automóvel:";
            // 
            // txtKmAutomovel
            // 
            txtKmAutomovel.Location = new Point(523, 124);
            txtKmAutomovel.Name = "txtKmAutomovel";
            txtKmAutomovel.ReadOnly = true;
            txtKmAutomovel.Size = new Size(258, 23);
            txtKmAutomovel.TabIndex = 46;
            // 
            // cmbAutomovel
            // 
            cmbAutomovel.Enabled = false;
            cmbAutomovel.FormattingEnabled = true;
            cmbAutomovel.Location = new Point(523, 95);
            cmbAutomovel.Name = "cmbAutomovel";
            cmbAutomovel.Size = new Size(258, 23);
            cmbAutomovel.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(448, 99);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 44;
            label7.Text = "Automóvel:";
            // 
            // cmbCondutor
            // 
            cmbCondutor.Enabled = false;
            cmbCondutor.FormattingEnabled = true;
            cmbCondutor.Location = new Point(523, 66);
            cmbCondutor.Name = "cmbCondutor";
            cmbCondutor.Size = new Size(258, 23);
            cmbCondutor.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(456, 70);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 42;
            label6.Text = "Condutor:";
            // 
            // txtDataLocacao
            // 
            txtDataLocacao.Enabled = false;
            txtDataLocacao.Format = DateTimePickerFormat.Short;
            txtDataLocacao.Location = new Point(145, 153);
            txtDataLocacao.MinDate = new DateTime(2023, 8, 9, 0, 0, 0, 0);
            txtDataLocacao.Name = "txtDataLocacao";
            txtDataLocacao.Size = new Size(258, 23);
            txtDataLocacao.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 157);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 40;
            label5.Text = "Data Locação:";
            // 
            // cmbPlanoCobranca
            // 
            cmbPlanoCobranca.Enabled = false;
            cmbPlanoCobranca.FormattingEnabled = true;
            cmbPlanoCobranca.Location = new Point(145, 124);
            cmbPlanoCobranca.Name = "cmbPlanoCobranca";
            cmbPlanoCobranca.Size = new Size(258, 23);
            cmbPlanoCobranca.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 128);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 38;
            label4.Text = "Plano de Cobrança:";
            // 
            // cmbGrupoAutomovel
            // 
            cmbGrupoAutomovel.Enabled = false;
            cmbGrupoAutomovel.FormattingEnabled = true;
            cmbGrupoAutomovel.Location = new Point(145, 95);
            cmbGrupoAutomovel.Name = "cmbGrupoAutomovel";
            cmbGrupoAutomovel.Size = new Size(258, 23);
            cmbGrupoAutomovel.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 99);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 36;
            label3.Text = "Grupo de Automóveis:";
            // 
            // cmbCliente
            // 
            cmbCliente.Enabled = false;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(145, 66);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(258, 23);
            cmbCliente.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 70);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 34;
            label2.Text = "Cliente:";
            // 
            // cmbFuncionario
            // 
            cmbFuncionario.Enabled = false;
            cmbFuncionario.FormattingEnabled = true;
            cmbFuncionario.Location = new Point(145, 37);
            cmbFuncionario.Name = "cmbFuncionario";
            cmbFuncionario.Size = new Size(258, 23);
            cmbFuncionario.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 41);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 32;
            label1.Text = "Funcionário:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(697, 591);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 61);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(600, 591);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(91, 61);
            btnSalvar.TabIndex = 30;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtDataDevolucao
            // 
            txtDataDevolucao.Format = DateTimePickerFormat.Short;
            txtDataDevolucao.Location = new Point(145, 211);
            txtDataDevolucao.MinDate = new DateTime(2023, 8, 9, 0, 0, 0, 0);
            txtDataDevolucao.Name = "txtDataDevolucao";
            txtDataDevolucao.Size = new Size(258, 23);
            txtDataDevolucao.TabIndex = 57;
            txtDataDevolucao.Value = new DateTime(2023, 8, 9, 21, 49, 12, 0);
            txtDataDevolucao.ValueChanged += txtDataDevolucao_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(46, 215);
            label12.Name = "label12";
            label12.Size = new Size(93, 15);
            label12.TabIndex = 56;
            label12.Text = "Data Devolução:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(432, 215);
            label13.Name = "label13";
            label13.Size = new Size(85, 15);
            label13.TabIndex = 59;
            label13.Text = "Km Percorrida:";
            // 
            // txtKmPercorrida
            // 
            txtKmPercorrida.Location = new Point(523, 211);
            txtKmPercorrida.Name = "txtKmPercorrida";
            txtKmPercorrida.Size = new Size(258, 23);
            txtKmPercorrida.TabIndex = 58;
            txtKmPercorrida.TextChanged += txtKmPercorrida_TextChanged;
            txtKmPercorrida.KeyPress += txtKmPercorrida_KeyPress;
            // 
            // cmbNivelTanque
            // 
            cmbNivelTanque.Enabled = false;
            cmbNivelTanque.FormattingEnabled = true;
            cmbNivelTanque.Location = new Point(145, 240);
            cmbNivelTanque.Name = "cmbNivelTanque";
            cmbNivelTanque.Size = new Size(258, 23);
            cmbNivelTanque.TabIndex = 61;
            cmbNivelTanque.SelectedIndexChanged += cmbNivelTanque_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(44, 244);
            label14.Name = "label14";
            label14.Size = new Size(95, 15);
            label14.TabIndex = 60;
            label14.Text = "Nível do Tanque:";
            // 
            // TelaDevolucaoAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 664);
            Controls.Add(cmbNivelTanque);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(txtKmPercorrida);
            Controls.Add(txtDataDevolucao);
            Controls.Add(label12);
            Controls.Add(txtValorTotal);
            Controls.Add(label11);
            Controls.Add(tabControl);
            Controls.Add(label10);
            Controls.Add(txtCupom);
            Controls.Add(txtDataDevolucaoPrevista);
            Controls.Add(label9);
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
            Name = "TelaDevolucaoAluguelForm";
            Text = "TelaDevolucaoAluguelForm";
            tabControl.ResumeLayout(false);
            tp1.ResumeLayout(false);
            tp2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox txtKmPercorrida;
        private ComboBox cmbNivelTanque;
        private Label label14;
    }
}