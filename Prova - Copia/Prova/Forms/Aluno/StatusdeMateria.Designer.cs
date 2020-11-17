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
			this.btnMenu = new System.Windows.Forms.Button();
			this.txbNome = new System.Windows.Forms.TextBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.cbxMaterias = new System.Windows.Forms.ComboBox();
			this.btnTempo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dtgvListar)).BeginInit();
			this.SuspendLayout();
			// 
			// btnFinalizar
			// 
			this.btnFinalizar.Location = new System.Drawing.Point(403, 73);
			this.btnFinalizar.Margin = new System.Windows.Forms.Padding(2);
			this.btnFinalizar.Name = "btnFinalizar";
			this.btnFinalizar.Size = new System.Drawing.Size(58, 22);
			this.btnFinalizar.TabIndex = 22;
			this.btnFinalizar.Text = "Finalizar";
			this.btnFinalizar.UseVisualStyleBackColor = true;
			this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(403, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 13);
			this.label1.TabIndex = 20;
			this.label1.Text = "Informe a matéria concluida:";
			// 
			// dtgvListar
			// 
			this.dtgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvListar.Location = new System.Drawing.Point(9, 128);
			this.dtgvListar.Margin = new System.Windows.Forms.Padding(2);
			this.dtgvListar.Name = "dtgvListar";
			this.dtgvListar.RowHeadersWidth = 51;
			this.dtgvListar.RowTemplate.Height = 24;
			this.dtgvListar.Size = new System.Drawing.Size(782, 266);
			this.dtgvListar.TabIndex = 19;
			// 
			// btnVerificar
			// 
			this.btnVerificar.Location = new System.Drawing.Point(49, 64);
			this.btnVerificar.Margin = new System.Windows.Forms.Padding(2);
			this.btnVerificar.Name = "btnVerificar";
			this.btnVerificar.Size = new System.Drawing.Size(76, 23);
			this.btnVerificar.TabIndex = 18;
			this.btnVerificar.Text = "Verificar";
			this.btnVerificar.UseVisualStyleBackColor = true;
			this.btnVerificar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// txtBoxID
			// 
			this.txtBoxID.Location = new System.Drawing.Point(49, 24);
			this.txtBoxID.Margin = new System.Windows.Forms.Padding(2);
			this.txtBoxID.Name = "txtBoxID";
			this.txtBoxID.Size = new System.Drawing.Size(134, 20);
			this.txtBoxID.TabIndex = 17;
			// 
			// lblInformeSeuNome
			// 
			this.lblInformeSeuNome.AutoSize = true;
			this.lblInformeSeuNome.Location = new System.Drawing.Point(46, 9);
			this.lblInformeSeuNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblInformeSeuNome.Name = "lblInformeSeuNome";
			this.lblInformeSeuNome.Size = new System.Drawing.Size(79, 13);
			this.lblInformeSeuNome.TabIndex = 16;
			this.lblInformeSeuNome.Text = "Informe seu ID:";
			// 
			// btnMenu
			// 
			this.btnMenu.Location = new System.Drawing.Point(694, 404);
			this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(98, 37);
			this.btnMenu.TabIndex = 23;
			this.btnMenu.Text = "Menu";
			this.btnMenu.UseVisualStyleBackColor = true;
			this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
			// 
			// txbNome
			// 
			this.txbNome.Location = new System.Drawing.Point(203, 24);
			this.txbNome.Margin = new System.Windows.Forms.Padding(2);
			this.txbNome.Name = "txbNome";
			this.txbNome.Size = new System.Drawing.Size(134, 20);
			this.txbNome.TabIndex = 25;
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(200, 9);
			this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(38, 13);
			this.lblNome.TabIndex = 24;
			this.lblNome.Text = "Nome:";
			// 
			// cbxMaterias
			// 
			this.cbxMaterias.FormattingEnabled = true;
			this.cbxMaterias.Location = new System.Drawing.Point(403, 47);
			this.cbxMaterias.Name = "cbxMaterias";
			this.cbxMaterias.Size = new System.Drawing.Size(121, 21);
			this.cbxMaterias.TabIndex = 26;
			// 
			// btnTempo
			// 
			this.btnTempo.Location = new System.Drawing.Point(466, 73);
			this.btnTempo.Margin = new System.Windows.Forms.Padding(2);
			this.btnTempo.Name = "btnTempo";
			this.btnTempo.Size = new System.Drawing.Size(58, 21);
			this.btnTempo.TabIndex = 27;
			this.btnTempo.Text = "Tempo";
			this.btnTempo.UseVisualStyleBackColor = true;
			this.btnTempo.Click += new System.EventHandler(this.btnTempo_Click);
			// 
			// StatusdeMateria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnTempo);
			this.Controls.Add(this.cbxMaterias);
			this.Controls.Add(this.txbNome);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.btnMenu);
			this.Controls.Add(this.btnFinalizar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtgvListar);
			this.Controls.Add(this.btnVerificar);
			this.Controls.Add(this.txtBoxID);
			this.Controls.Add(this.lblInformeSeuNome);
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
        private System.Windows.Forms.Button btnMenu;
		private System.Windows.Forms.TextBox txbNome;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.ComboBox cbxMaterias;
		private System.Windows.Forms.Button btnTempo;
	}
}