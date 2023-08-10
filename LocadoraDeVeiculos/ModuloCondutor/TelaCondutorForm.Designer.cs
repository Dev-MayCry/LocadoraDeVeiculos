namespace LocadoraDeVeiculos.WinApp.ModuloCondutor {
    partial class TelaCondutorForm {
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
            txtListaClientes = new ComboBox();
            label2 = new Label();
            btnCliente = new CheckBox();
            txtEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtData = new DateTimePicker();
            txtTelefone = new MaskedTextBox();
            txtCpf = new MaskedTextBox();
            txtCnh = new MaskedTextBox();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(99, 107);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(367, 23);
            txtNome.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 111);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 19;
            label1.Text = "Nome:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(375, 195);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 61);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(278, 195);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(91, 61);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtListaClientes
            // 
            txtListaClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            txtListaClientes.FormattingEnabled = true;
            txtListaClientes.Location = new Point(99, 53);
            txtListaClientes.Name = "txtListaClientes";
            txtListaClientes.Size = new Size(367, 23);
            txtListaClientes.TabIndex = 21;
            txtListaClientes.SelectedIndexChanged += txtListaClientes_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 57);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 22;
            label2.Text = "Cliente:";
            // 
            // btnCliente
            // 
            btnCliente.AutoSize = true;
            btnCliente.Location = new Point(99, 82);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(124, 19);
            btnCliente.TabIndex = 23;
            btnCliente.Text = "Cliente é condutor";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.CheckedChanged += btnCliente_CheckedChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(99, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(367, 23);
            txtEmail.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 140);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 24;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 169);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 26;
            label4.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 169);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 28;
            label5.Text = "CPF:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 198);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 30;
            label6.Text = "CNH:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 230);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 32;
            label7.Text = "Validade:";
            // 
            // txtData
            // 
            txtData.CustomFormat = "dd/MM/yyyy";
            txtData.Format = DateTimePickerFormat.Custom;
            txtData.Location = new Point(99, 226);
            txtData.MinDate = new DateTime(2023, 8, 9, 0, 0, 0, 0);
            txtData.Name = "txtData";
            txtData.Size = new Size(155, 23);
            txtData.TabIndex = 33;
            txtData.Value = new DateTime(2023, 8, 9, 21, 8, 20, 0);
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(99, 165);
            txtTelefone.Mask = "(99) 0 0000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(155, 23);
            txtTelefone.TabIndex = 34;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(311, 165);
            txtCpf.Mask = "000 000 000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(155, 23);
            txtCpf.TabIndex = 35;
            // 
            // txtCnh
            // 
            txtCnh.Location = new Point(96, 194);
            txtCnh.Mask = "0000000000";
            txtCnh.Name = "txtCnh";
            txtCnh.Size = new Size(158, 23);
            txtCnh.TabIndex = 36;
            // 
            // TelaCondutorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 268);
            Controls.Add(txtCnh);
            Controls.Add(txtCpf);
            Controls.Add(txtTelefone);
            Controls.Add(txtData);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(btnCliente);
            Controls.Add(label2);
            Controls.Add(txtListaClientes);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Name = "TelaCondutorForm";
            Text = "Tela de Condutores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNome;
        private Label label1;
        private Button btnCancelar;
        private Button btnSalvar;
        private ComboBox txtListaClientes;
        private Label label2;
        private CheckBox btnCliente;
        private TextBox txtEmail;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker txtData;
        private MaskedTextBox txtTelefone;
        private MaskedTextBox txtCpf;
        private MaskedTextBox txtCnh;
    }
}