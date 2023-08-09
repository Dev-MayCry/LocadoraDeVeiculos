namespace LocadoraDeVeiculos.WinApp.ModuloAluguel {
    partial class TelaPrecoForm {
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
            this.txtDiesel = new System.Windows.Forms.TextBox();
            this.txtAlcool = new System.Windows.Forms.TextBox();
            this.txtGasolina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(411, 198);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 50);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtDiesel
            // 
            this.txtDiesel.Location = new System.Drawing.Point(103, 63);
            this.txtDiesel.Name = "txtDiesel";
            this.txtDiesel.Size = new System.Drawing.Size(367, 23);
            this.txtDiesel.TabIndex = 54;
            // 
            // txtAlcool
            // 
            this.txtAlcool.Location = new System.Drawing.Point(103, 22);
            this.txtAlcool.Name = "txtAlcool";
            this.txtAlcool.Size = new System.Drawing.Size(367, 23);
            this.txtAlcool.TabIndex = 53;
            // 
            // txtGasolina
            // 
            this.txtGasolina.Location = new System.Drawing.Point(103, 145);
            this.txtGasolina.Name = "txtGasolina";
            this.txtGasolina.Size = new System.Drawing.Size(367, 23);
            this.txtGasolina.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 47;
            this.label6.Text = "Gasolina: ";
            // 
            // txtGas
            // 
            this.txtGas.Location = new System.Drawing.Point(103, 104);
            this.txtGas.Name = "txtGas";
            this.txtGas.Size = new System.Drawing.Size(367, 23);
            this.txtGas.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "Gás: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Diesel: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "Álcool:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(313, 198);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 50);
            this.btnSalvar.TabIndex = 40;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // TelaPrecoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 260);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDiesel);
            this.Controls.Add(this.txtAlcool);
            this.Controls.Add(this.txtGasolina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalvar);
            this.Name = "TelaPrecoForm";
            this.Text = "TelaPrecoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancelar;
        private TextBox txtDiesel;
        private TextBox txtAlcool;
        private TextBox txtGasolina;
        private Label label6;
        private TextBox txtGas;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSalvar;
    }
}