namespace Prova.Forms.Aluno
{
    partial class StatusdeMateria
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
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvListar = new System.Windows.Forms.DataGridView();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.lblInformeSeuNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.cbxMaterias = new System.Windows.Forms.ComboBox();
            this.btnTempo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Teal;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(543, 90);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(184, 48);
            this.btnFinalizar.TabIndex = 22;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Informe a matéria concluida:";
            // 
            // dtgvListar
            // 
            this.dtgvListar.BackgroundColor = System.Drawing.Color.Teal;
            this.dtgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListar.Location = new System.Drawing.Point(12, 158);
            this.dtgvListar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvListar.Name = "dtgvListar";
            this.dtgvListar.RowHeadersWidth = 51;
            this.dtgvListar.RowTemplate.Height = 24;
            this.dtgvListar.Size = new System.Drawing.Size(1043, 327);
            this.dtgvListar.TabIndex = 19;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Teal;
            this.btnVerificar.FlatAppearance.BorderSize = 0;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(124, 90);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(223, 57);
            this.btnVerificar.TabIndex = 18;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtBoxID
            // 
            this.txtBoxID.BackColor = System.Drawing.Color.Teal;
            this.txtBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxID.ForeColor = System.Drawing.Color.White;
            this.txtBoxID.Location = new System.Drawing.Point(65, 38);
            this.txtBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(178, 30);
            this.txtBoxID.TabIndex = 17;
            // 
            // lblInformeSeuNome
            // 
            this.lblInformeSeuNome.AutoSize = true;
            this.lblInformeSeuNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformeSeuNome.Location = new System.Drawing.Point(61, 11);
            this.lblInformeSeuNome.Name = "lblInformeSeuNome";
            this.lblInformeSeuNome.Size = new System.Drawing.Size(159, 25);
            this.lblInformeSeuNome.TabIndex = 16;
            this.lblInformeSeuNome.Text = "Informe seu ID:";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.MintCream;
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.ForeColor = System.Drawing.Color.White;
            this.txbNome.Location = new System.Drawing.Point(272, 38);
            this.txbNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(178, 30);
            this.txbNome.TabIndex = 25;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(267, 11);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(75, 25);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome:";
            // 
            // cbxMaterias
            // 
            this.cbxMaterias.BackColor = System.Drawing.Color.Teal;
            this.cbxMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaterias.ForeColor = System.Drawing.Color.White;
            this.cbxMaterias.FormattingEnabled = true;
            this.cbxMaterias.Location = new System.Drawing.Point(620, 49);
            this.cbxMaterias.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMaterias.Name = "cbxMaterias";
            this.cbxMaterias.Size = new System.Drawing.Size(212, 33);
            this.cbxMaterias.TabIndex = 26;
            // 
            // btnTempo
            // 
            this.btnTempo.BackColor = System.Drawing.Color.Teal;
            this.btnTempo.FlatAppearance.BorderSize = 0;
            this.btnTempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTempo.ForeColor = System.Drawing.Color.White;
            this.btnTempo.Location = new System.Drawing.Point(732, 90);
            this.btnTempo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTempo.Name = "btnTempo";
            this.btnTempo.Size = new System.Drawing.Size(184, 48);
            this.btnTempo.TabIndex = 27;
            this.btnTempo.Text = "Tempo";
            this.btnTempo.UseVisualStyleBackColor = false;
            this.btnTempo.Click += new System.EventHandler(this.btnTempo_Click);
            // 
            // StatusdeMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnTempo);
            this.Controls.Add(this.cbxMaterias);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvListar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.lblInformeSeuNome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StatusdeMateria";
            this.Text = "StatusdeMateria";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvListar;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label lblInformeSeuNome;
		private System.Windows.Forms.TextBox txbNome;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.ComboBox cbxMaterias;
		private System.Windows.Forms.Button btnTempo;
	}
}