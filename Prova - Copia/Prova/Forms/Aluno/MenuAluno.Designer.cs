namespace Prova.Forms.Aluno
{
    partial class MenuAluno
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
            this.btnFormAlterar = new System.Windows.Forms.Button();
            this.btnFormListaAlunos = new System.Windows.Forms.Button();
            this.btnFormExcluir = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormAlterar
            // 
            this.btnFormAlterar.Location = new System.Drawing.Point(494, 97);
            this.btnFormAlterar.Name = "btnFormAlterar";
            this.btnFormAlterar.Size = new System.Drawing.Size(154, 85);
            this.btnFormAlterar.TabIndex = 0;
            this.btnFormAlterar.Text = "Alterar meus dados";
            this.btnFormAlterar.UseVisualStyleBackColor = true;
            this.btnFormAlterar.Click += new System.EventHandler(this.btnFormAlterar_Click);
            // 
            // btnFormListaAlunos
            // 
            this.btnFormListaAlunos.Location = new System.Drawing.Point(494, 211);
            this.btnFormListaAlunos.Name = "btnFormListaAlunos";
            this.btnFormListaAlunos.Size = new System.Drawing.Size(154, 85);
            this.btnFormListaAlunos.TabIndex = 1;
            this.btnFormListaAlunos.Text = "Vizualizar alunos";
            this.btnFormListaAlunos.UseVisualStyleBackColor = true;
            // 
            // btnFormExcluir
            // 
            this.btnFormExcluir.Location = new System.Drawing.Point(494, 325);
            this.btnFormExcluir.Name = "btnFormExcluir";
            this.btnFormExcluir.Size = new System.Drawing.Size(154, 85);
            this.btnFormExcluir.TabIndex = 2;
            this.btnFormExcluir.Text = "Excluir meus dados";
            this.btnFormExcluir.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(1030, 530);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(130, 45);
            this.btnMenu.TabIndex = 19;
            this.btnMenu.Text = "Menu Principal";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // MenuAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 587);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnFormExcluir);
            this.Controls.Add(this.btnFormListaAlunos);
            this.Controls.Add(this.btnFormAlterar);
            this.Name = "MenuAluno";
            this.Text = "MenuAluno";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormAlterar;
        private System.Windows.Forms.Button btnFormListaAlunos;
        private System.Windows.Forms.Button btnFormExcluir;
        private System.Windows.Forms.Button btnMenu;
    }
}