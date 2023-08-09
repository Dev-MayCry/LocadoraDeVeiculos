namespace LocadoraDeVeiculos.WinApp.ModuloAutomovel {
    partial class TelaFiltroAutomovelForm {
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
            btnCancelar = new Button();
            btnSalvar = new Button();
            txtListaGrupoAutomoveis = new ComboBox();
            btnResetar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(184, 15);
            label1.TabIndex = 0;
            label1.Text = "Selecione o Grupo de Automóvel:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(359, 90);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 50);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(167, 90);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 50);
            btnSalvar.TabIndex = 36;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtListaGrupoAutomoveis
            // 
            txtListaGrupoAutomoveis.DropDownStyle = ComboBoxStyle.DropDownList;
            txtListaGrupoAutomoveis.FormattingEnabled = true;
            txtListaGrupoAutomoveis.Location = new Point(12, 54);
            txtListaGrupoAutomoveis.Name = "txtListaGrupoAutomoveis";
            txtListaGrupoAutomoveis.Size = new Size(437, 23);
            txtListaGrupoAutomoveis.TabIndex = 38;
            // 
            // btnResetar
            // 
            btnResetar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnResetar.DialogResult = DialogResult.Abort;
            btnResetar.Location = new Point(263, 90);
            btnResetar.Name = "btnResetar";
            btnResetar.Size = new Size(90, 50);
            btnResetar.TabIndex = 39;
            btnResetar.Text = "Resetar";
            btnResetar.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroAutomovelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 152);
            Controls.Add(btnResetar);
            Controls.Add(txtListaGrupoAutomoveis);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label1);
            Name = "TelaFiltroAutomovelForm";
            Text = "Filtro de Automóveis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancelar;
        private Button btnSalvar;
        private ComboBox txtListaGrupoAutomoveis;
        private Button btnResetar;
    }
}