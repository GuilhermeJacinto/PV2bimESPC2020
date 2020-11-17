namespace Prova.Forms.Aluno
{
    partial class AlterarAluno
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtualizaDados = new System.Windows.Forms.Button();
            this.txtBoxNovoCPF = new System.Windows.Forms.TextBox();
            this.txtBoxNovoNome = new System.Windows.Forms.TextBox();
            this.dataGridDados = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Novo nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Novo CPF:";
            // 
            // btnAtualizaDados
            // 
            this.btnAtualizaDados.Location = new System.Drawing.Point(827, 104);
            this.btnAtualizaDados.Name = "btnAtualizaDados";
            this.btnAtualizaDados.Size = new System.Drawing.Size(130, 45);
            this.btnAtualizaDados.TabIndex = 15;
            this.btnAtualizaDados.Text = "Atualizar dados";
            this.btnAtualizaDados.UseVisualStyleBackColor = true;
            this.btnAtualizaDados.Click += new System.EventHandler(this.btnAtualizaDados_Click);
            // 
            // txtBoxNovoCPF
            // 
            this.txtBoxNovoCPF.Location = new System.Drawing.Point(619, 139);
            this.txtBoxNovoCPF.Name = "txtBoxNovoCPF";
            this.txtBoxNovoCPF.Size = new System.Drawing.Size(161, 22);
            this.txtBoxNovoCPF.TabIndex = 14;
            // 
            // txtBoxNovoNome
            // 
            this.txtBoxNovoNome.Location = new System.Drawing.Point(619, 92);
            this.txtBoxNovoNome.Name = "txtBoxNovoNome";
            this.txtBoxNovoNome.Size = new System.Drawing.Size(161, 22);
            this.txtBoxNovoNome.TabIndex = 13;
            // 
            // dataGridDados
            // 
            this.dataGridDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDados.Location = new System.Drawing.Point(12, 248);
            this.dataGridDados.Name = "dataGridDados";
            this.dataGridDados.RowHeadersWidth = 51;
            this.dataGridDados.RowTemplate.Height = 24;
            this.dataGridDados.Size = new System.Drawing.Size(1148, 269);
            this.dataGridDados.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(226, 142);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(130, 45);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(211, 95);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(161, 22);
            this.txtBoxID.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Informe seu ID:";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(1030, 530);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(130, 45);
            this.btnMenu.TabIndex = 18;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // AlterarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 587);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAtualizaDados);
            this.Controls.Add(this.txtBoxNovoCPF);
            this.Controls.Add(this.txtBoxNovoNome);
            this.Controls.Add(this.dataGridDados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.label1);
            this.Name = "AlterarAluno";
            this.Text = "AlterarAlunos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtualizaDados;
        private System.Windows.Forms.TextBox txtBoxNovoCPF;
        private System.Windows.Forms.TextBox txtBoxNovoNome;
        private System.Windows.Forms.DataGridView dataGridDados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
    }
}