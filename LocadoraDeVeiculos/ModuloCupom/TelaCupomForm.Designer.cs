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
            label5 = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 62);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 91);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "Data Validade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 149);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Parceiro:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(98, 59);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(226, 23);
            txtNome.TabIndex = 4;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(98, 88);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(119, 23);
            txtValor.TabIndex = 5;
            // 
            // dataValidade
            // 
            dataValidade.Location = new Point(98, 117);
            dataValidade.Name = "dataValidade";
            dataValidade.Size = new Size(119, 23);
            dataValidade.TabIndex = 8;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(268, 181);
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
            button1.Location = new Point(171, 181);
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
            txtListaParceiro.Location = new Point(98, 146);
            txtListaParceiro.Name = "txtListaParceiro";
            txtListaParceiro.Size = new Size(163, 23);
            txtListaParceiro.TabIndex = 11;
           
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 33);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 13;
            label5.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(98, 30);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(30, 23);
            txtId.TabIndex = 12;
            txtId.Text = "0";
            // 
            // TelaCupomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 254);
            Controls.Add(label5);
            Controls.Add(txtId);
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
        private Label label5;
        private TextBox txtId;
    }
}