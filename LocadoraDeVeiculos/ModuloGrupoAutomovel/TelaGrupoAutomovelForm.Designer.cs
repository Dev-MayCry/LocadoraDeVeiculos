namespace LocadoraDeVeiculos.WinApp.ModuloGrupoAutomovel {
    partial class TelaGrupoAutomovelForm {
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
            label2 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            button2 = new Button();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 26);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 11;
            label2.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(80, 23);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(30, 23);
            txtId.TabIndex = 10;
            txtId.Text = "0";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(80, 67);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(367, 23);
            txtNome.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 70);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 8;
            label1.Text = "Nome: ";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(356, 106);
            button2.Name = "button2";
            button2.Size = new Size(91, 61);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(259, 106);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(91, 61);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // TelaGrupoAutomovelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 179);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnSalvar);
            Name = "TelaGrupoAutomovelForm";
            Text = "Cadastro de Grupo de Automóvel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label1;
        private Button button2;
        private Button btnSalvar;
    }
}