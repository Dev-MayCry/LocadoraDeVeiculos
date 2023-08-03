namespace LocadoraDeVeiculos.WinApp.ModuloAutomovel {
    partial class TelaAutomovelForm {
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
            btnSalvar = new Button();
            label2 = new Label();
            label3 = new Label();
            txtCor = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtCapacidadeLitros = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtListaGrupoAutomoveis = new ComboBox();
            txtListaTipoCombustivel = new ComboBox();
            txtAno = new NumericUpDown();
            fotoCarro = new PictureBox();
            btnBuscar = new Button();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            btnCancelar = new Button();
            label9 = new Label();
            txtPlaca = new TextBox();
            ((System.ComponentModel.ISupportInitialize)txtAno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fotoCarro).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 200);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 12;
            label1.Text = "Grupo de Automóveis:";
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(342, 413);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 50);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 229);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 14;
            label2.Text = "Modelo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 258);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 16;
            label3.Text = "Marca:";
            // 
            // txtCor
            // 
            txtCor.Location = new Point(161, 284);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(367, 23);
            txtCor.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 287);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 18;
            label4.Text = "Cor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 316);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 20;
            label5.Text = "Tipo de Combustível:";
            // 
            // txtCapacidadeLitros
            // 
            txtCapacidadeLitros.Location = new Point(161, 342);
            txtCapacidadeLitros.Name = "txtCapacidadeLitros";
            txtCapacidadeLitros.Size = new Size(367, 23);
            txtCapacidadeLitros.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 345);
            label6.Name = "label6";
            label6.Size = new Size(124, 15);
            label6.TabIndex = 22;
            label6.Text = "Capacidade em Litros:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(370, 374);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 24;
            label7.Text = "Ano:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(119, 109);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 26;
            label8.Text = "Foto: ";
            // 
            // txtListaGrupoAutomoveis
            // 
            txtListaGrupoAutomoveis.FormattingEnabled = true;
            txtListaGrupoAutomoveis.Location = new Point(161, 197);
            txtListaGrupoAutomoveis.Name = "txtListaGrupoAutomoveis";
            txtListaGrupoAutomoveis.Size = new Size(367, 23);
            txtListaGrupoAutomoveis.TabIndex = 27;
            // 
            // txtListaTipoCombustivel
            // 
            txtListaTipoCombustivel.FormattingEnabled = true;
            txtListaTipoCombustivel.Location = new Point(161, 313);
            txtListaTipoCombustivel.Name = "txtListaTipoCombustivel";
            txtListaTipoCombustivel.Size = new Size(367, 23);
            txtListaTipoCombustivel.TabIndex = 28;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(408, 372);
            txtAno.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            txtAno.Minimum = new decimal(new int[] { 1886, 0, 0, 0 });
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(120, 23);
            txtAno.TabIndex = 29;
            txtAno.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // fotoCarro
            // 
            fotoCarro.Location = new Point(162, 41);
            fotoCarro.Name = "fotoCarro";
            fotoCarro.Size = new Size(270, 150);
            fotoCarro.TabIndex = 31;
            fotoCarro.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(438, 91);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 50);
            btnBuscar.TabIndex = 32;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(161, 226);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(367, 23);
            txtModelo.TabIndex = 33;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(161, 255);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(367, 23);
            txtMarca.TabIndex = 34;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(440, 413);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 50);
            btnCancelar.TabIndex = 35;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(118, 374);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 36;
            label9.Text = "Placa:";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(161, 371);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(203, 23);
            txtPlaca.TabIndex = 37;
            // 
            // TelaAutomovelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 475);
            Controls.Add(txtPlaca);
            Controls.Add(label9);
            Controls.Add(btnCancelar);
            Controls.Add(txtMarca);
            Controls.Add(txtModelo);
            Controls.Add(btnBuscar);
            Controls.Add(fotoCarro);
            Controls.Add(txtAno);
            Controls.Add(txtListaTipoCombustivel);
            Controls.Add(txtListaGrupoAutomoveis);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtCapacidadeLitros);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Name = "TelaAutomovelForm";
            Text = "TelaAutomovelForm";
            ((System.ComponentModel.ISupportInitialize)txtAno).EndInit();
            ((System.ComponentModel.ISupportInitialize)fotoCarro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Button button2;
        private Button btnSalvar;
        private TextBox txtPlaca;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox txtCor;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox txtCapacidadeLitros;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private Label label8;
        private ComboBox txtListaGrupoAutomoveis;
        private ComboBox txtListaTipoCombustivel;
        private NumericUpDown txtAno;
        private PictureBox fotoCarro;
        private Button btnBuscar;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private Button btnCancelar;
        private Label label9;
    }
}