namespace LocadoraDeVeiculos.WinApp.ModuloCupom
{
    partial class TelaCupomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtValor = new TextBox();
            dataValidade = new DateTimePicker();
            button2 = new Button();
            button1 = new Button();
            txtListaParceiro = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 27);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 56);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 88);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "Data Validade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 114);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Parceiro:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(86, 24);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(226, 23);
            txtNome.TabIndex = 4;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(86, 53);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(119, 23);
            txtValor.TabIndex = 5;
            // 
            // dataValidade
            // 
            dataValidade.Format = DateTimePickerFormat.Short;
            dataValidade.Location = new Point(86, 82);
            dataValidade.Name = "dataValidade";
            dataValidade.Size = new Size(119, 23);
            dataValidade.TabIndex = 8;
            dataValidade.Value = new DateTime(2023, 8, 2, 16, 46, 12, 0);
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(256, 144);
            button2.Name = "button2";
            button2.Size = new Size(91, 61);
            button2.TabIndex = 10;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(159, 144);
            button1.Name = "button1";
            button1.Size = new Size(91, 61);
            button1.TabIndex = 9;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGravar_Click;
            // 
            // txtListaParceiro
            // 
            txtListaParceiro.DropDownStyle = ComboBoxStyle.DropDownList;
            txtListaParceiro.FormattingEnabled = true;
            txtListaParceiro.Location = new Point(86, 111);
            txtListaParceiro.Name = "txtListaParceiro";
            txtListaParceiro.Size = new Size(163, 23);
            txtListaParceiro.TabIndex = 11;
            // 
            // TelaCupomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 217);
            Controls.Add(txtListaParceiro);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataValidade);
            Controls.Add(txtValor);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaCupomForm";
            ShowIcon = false;
            Text = "Cadastro de Cupom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtValor;
        private DateTimePicker dataValidade;
        private Button button2;
        private Button button1;
        private ComboBox txtListaParceiro;
    }
}