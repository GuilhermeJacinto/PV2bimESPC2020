namespace Prova.Forms
{
    partial class Materia
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
			this.txbProcurarNome = new System.Windows.Forms.TextBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.richTextBoxListar = new System.Windows.Forms.RichTextBox();
			this.dataGVListar = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.materia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.materia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.materia3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.materia4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.materia5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nota4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nota5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.status1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.status2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.status3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.status4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.status5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGVListar)).BeginInit();
			this.SuspendLayout();
			// 
			// txbProcurarNome
			// 
			this.txbProcurarNome.Location = new System.Drawing.Point(160, 12);
			this.txbProcurarNome.Name = "txbProcurarNome";
			this.txbProcurarNome.Size = new System.Drawing.Size(100, 20);
			this.txbProcurarNome.TabIndex = 68;
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(27, 15);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(127, 13);
			this.lblNome.TabIndex = 67;
			this.lblNome.Text = "Informe o nome do aluno:";
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(266, 12);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
			this.btnPesquisar.TabIndex = 66;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// richTextBoxListar
			// 
			this.richTextBoxListar.Location = new System.Drawing.Point(12, 76);
			this.richTextBoxListar.Name = "richTextBoxListar";
			this.richTextBoxListar.Size = new System.Drawing.Size(386, 138);
			this.richTextBoxListar.TabIndex = 69;
			this.richTextBoxListar.Text = "";
			// 
			// dataGVListar
			// 
			this.dataGVListar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.dataGVListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGVListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.cpf,
            this.materia1,
            this.materia2,
            this.materia3,
            this.materia4,
            this.materia5,
            this.nota1,
            this.nota2,
            this.nota3,
            this.nota4,
            this.nota5,
            this.status1,
            this.status2,
            this.status3,
            this.status4,
            this.status5,
            this.dataInicio,
            this.dataFinal});
			this.dataGVListar.GridColor = System.Drawing.Color.White;
			this.dataGVListar.Location = new System.Drawing.Point(12, 76);
			this.dataGVListar.Name = "dataGVListar";
			this.dataGVListar.RowHeadersWidth = 51;
			this.dataGVListar.Size = new System.Drawing.Size(752, 288);
			this.dataGVListar.TabIndex = 95;
			this.dataGVListar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVListar_CellContentClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(347, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 23);
			this.button1.TabIndex = 96;
			this.button1.Text = "Minhas Disciplinas";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(461, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(108, 23);
			this.button2.TabIndex = 97;
			this.button2.Text = "Status da Matéria";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// id
			// 
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			// 
			// nome
			// 
			this.nome.HeaderText = "Nome";
			this.nome.Name = "nome";
			// 
			// cpf
			// 
			this.cpf.HeaderText = "CPF";
			this.cpf.Name = "cpf";
			// 
			// materia1
			// 
			this.materia1.HeaderText = "Materia 1";
			this.materia1.Name = "materia1";
			// 
			// materia2
			// 
			this.materia2.HeaderText = "Materia 2";
			this.materia2.Name = "materia2";
			// 
			// materia3
			// 
			this.materia3.HeaderText = "Materia 3";
			this.materia3.Name = "materia3";
			// 
			// materia4
			// 
			this.materia4.HeaderText = "Materia 4";
			this.materia4.Name = "materia4";
			// 
			// materia5
			// 
			this.materia5.HeaderText = "Materia 5";
			this.materia5.Name = "materia5";
			// 
			// nota1
			// 
			this.nota1.HeaderText = "Nota 1";
			this.nota1.Name = "nota1";
			// 
			// nota2
			// 
			this.nota2.HeaderText = "Nota 2";
			this.nota2.Name = "nota2";
			// 
			// nota3
			// 
			this.nota3.HeaderText = "Nota 3";
			this.nota3.Name = "nota3";
			// 
			// nota4
			// 
			this.nota4.HeaderText = "Nota 4";
			this.nota4.Name = "nota4";
			// 
			// nota5
			// 
			this.nota5.HeaderText = "Nota 5";
			this.nota5.Name = "nota5";
			// 
			// status1
			// 
			this.status1.HeaderText = "status1";
			this.status1.Name = "status1";
			// 
			// status2
			// 
			this.status2.HeaderText = "status2";
			this.status2.Name = "status2";
			// 
			// status3
			// 
			this.status3.HeaderText = "status3";
			this.status3.Name = "status3";
			// 
			// status4
			// 
			this.status4.HeaderText = "status4";
			this.status4.Name = "status4";
			// 
			// status5
			// 
			this.status5.HeaderText = "status5";
			this.status5.Name = "status5";
			// 
			// dataInicio
			// 
			this.dataInicio.HeaderText = "Data de Inicio";
			this.dataInicio.Name = "dataInicio";
			// 
			// dataFinal
			// 
			this.dataFinal.HeaderText = "Data de Encerramento";
			this.dataFinal.Name = "dataFinal";
			// 
			// Materia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGVListar);
			this.Controls.Add(this.richTextBoxListar);
			this.Controls.Add(this.txbProcurarNome);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.btnPesquisar);
			this.Name = "Materia";
			this.Text = "Materia";
			((System.ComponentModel.ISupportInitialize)(this.dataGVListar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbProcurarNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RichTextBox richTextBoxListar;
        private System.Windows.Forms.DataGridView dataGVListar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn nome;
		private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
		private System.Windows.Forms.DataGridViewTextBoxColumn materia1;
		private System.Windows.Forms.DataGridViewTextBoxColumn materia2;
		private System.Windows.Forms.DataGridViewTextBoxColumn materia3;
		private System.Windows.Forms.DataGridViewTextBoxColumn materia4;
		private System.Windows.Forms.DataGridViewTextBoxColumn materia5;
		private System.Windows.Forms.DataGridViewTextBoxColumn nota1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nota2;
		private System.Windows.Forms.DataGridViewTextBoxColumn nota3;
		private System.Windows.Forms.DataGridViewTextBoxColumn nota4;
		private System.Windows.Forms.DataGridViewTextBoxColumn nota5;
		private System.Windows.Forms.DataGridViewTextBoxColumn status1;
		private System.Windows.Forms.DataGridViewTextBoxColumn status2;
		private System.Windows.Forms.DataGridViewTextBoxColumn status3;
		private System.Windows.Forms.DataGridViewTextBoxColumn status4;
		private System.Windows.Forms.DataGridViewTextBoxColumn status5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataInicio;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataFinal;
	}
}