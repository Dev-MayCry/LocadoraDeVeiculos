namespace LocadoraDeVeiculos.WinApp.ModuloTaxaServico {
    partial class TelaTaxaServicoForm {
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
            txtNome = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            txtPreco = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnCobrancaDiaria = new RadioButton();
            btnPrecoFixo = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(85, 56);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(367, 23);
            txtNome.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 59);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 12;
            label1.Text = "Nome: ";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(361, 190);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 61);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(264, 190);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(91, 61);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(85, 85);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(259, 23);
            txtPreco.TabIndex = 15;
            txtPreco.KeyPress += textPreco_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 88);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 14;
            label2.Text = "Preço: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCobrancaDiaria);
            groupBox1.Controls.Add(btnPrecoFixo);
            groupBox1.Location = new Point(85, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 70);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Plano de Cálculo";
            // 
            // btnCobrancaDiaria
            // 
            btnCobrancaDiaria.AutoSize = true;
            btnCobrancaDiaria.Location = new Point(150, 30);
            btnCobrancaDiaria.Name = "btnCobrancaDiaria";
            btnCobrancaDiaria.Size = new Size(109, 19);
            btnCobrancaDiaria.TabIndex = 1;
            btnCobrancaDiaria.TabStop = true;
            btnCobrancaDiaria.Text = "Cobrança Diária";
            btnCobrancaDiaria.UseVisualStyleBackColor = true;
            // 
            // btnPrecoFixo
            // 
            btnPrecoFixo.AutoSize = true;
            btnPrecoFixo.Location = new Point(23, 30);
            btnPrecoFixo.Name = "btnPrecoFixo";
            btnPrecoFixo.Size = new Size(80, 19);
            btnPrecoFixo.TabIndex = 0;
            btnPrecoFixo.TabStop = true;
            btnPrecoFixo.Text = "Preço Fixo";
            btnPrecoFixo.UseVisualStyleBackColor = true;
            // 
            // TelaTaxaServicoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 263);
            Controls.Add(groupBox1);
            Controls.Add(txtPreco);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Name = "TelaTaxaServicoForm";
            Text = "TelaTaxaServicoForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox txtPreco;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton btnCobrancaDiaria;
        private RadioButton btnPrecoFixo;
    }
}