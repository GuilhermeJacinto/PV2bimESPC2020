namespace Prova.Forms.Professor
{
    partial class LancamentodeNota
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtBoxNota1 = new System.Windows.Forms.TextBox();
			this.btnDarNota = new System.Windows.Forms.Button();
			this.btnMenu = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBoxBuscaAluno = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtBoxNota5 = new System.Windows.Forms.TextBox();
			this.txtBoxNota4 = new System.Windows.Forms.TextBox();
			this.txtBoxNota3 = new System.Windows.Forms.TextBox();
			this.txtBoxNota2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.dataGVListar = new System.Windows.Forms.DataGridView();
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
			this.btnMostrarFinalizados = new System.Windows.Forms.Button();
			this.lblMostrar = new System.Windows.Forms.Label();
			this.lblAtrasados = new System.Windows.Forms.Label();
			this.btnMostrarAtrasado = new System.Windows.Forms.Button();
			this.btnAlterarPrazo = new System.Windows.Forms.Button();
			this.btnAtualizar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGVListar)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 50);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 13);
			this.label1.TabIndex = 25;
			this.label1.Text = "Informe a nota da 1° matéria:";
			// 
			// txtBoxNota1
			// 
			this.txtBoxNota1.Location = new System.Drawing.Point(171, 50);
			this.txtBoxNota1.Margin = new System.Windows.Forms.Padding(2);
			this.txtBoxNota1.Name = "txtBoxNota1";
			this.txtBoxNota1.Size = new System.Drawing.Size(68, 20);
			this.txtBoxNota1.TabIndex = 24;
			// 
			// btnDarNota
			// 
			this.btnDarNota.Location = new System.Drawing.Point(254, 115);
			this.btnDarNota.Margin = new System.Windows.Forms.Padding(2);
			this.btnDarNota.Name = "btnDarNota";
			this.btnDarNota.Size = new System.Drawing.Size(97, 26);
			this.btnDarNota.TabIndex = 22;
			this.btnDarNota.Text = "Atribuir Notas";
			this.btnDarNota.UseVisualStyleBackColor = true;
			this.btnDarNota.Click += new System.EventHandler(this.btnDarNota_Click);
			// 
			// btnMenu
			// 
			this.btnMenu.Location = new System.Drawing.Point(694, 403);
			this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(97, 38);
			this.btnMenu.TabIndex = 28;
			this.btnMenu.Text = "Menu";
			this.btnMenu.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 9);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 13);
			this.label3.TabIndex = 29;
			this.label3.Text = "Informe o ID do aluno:";
			// 
			// txtBoxBuscaAluno
			// 
			this.txtBoxBuscaAluno.Location = new System.Drawing.Point(137, 6);
			this.txtBoxBuscaAluno.Margin = new System.Windows.Forms.Padding(2);
			this.txtBoxBuscaAluno.Name = "txtBoxBuscaAluno";
			this.txtBoxBuscaAluno.Size = new System.Drawing.Size(68, 20);
			this.txtBoxBuscaAluno.TabIndex = 30;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(209, 4);
			this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(54, 23);
			this.btnBuscar.TabIndex = 31;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txtBoxNota5
			// 
			this.txtBoxNota5.Location = new System.Drawing.Point(171, 186);
			this.txtBoxNota5.Margin = new System.Windows.Forms.Padding(2);
			this.txtBoxNota5.Name = "txtBoxNota5";
			this.txtBoxNota5.Size = new System.Drawing.Size(68, 20);
			this.txtBoxNota5.TabIndex = 33;
			// 
			// txtBoxNota4
			// 
			this.txtBoxNota4.Location = new System.Drawing.Point(171, 152);
			this.txtBoxNota4.Margin = new System.Windows.Forms.Padding(2);
			this.txtBoxNota4.Name = "txtBoxNota4";
			this.txtBoxNota4.Size = new System.Drawing.Size(68, 20);
			this.txtBoxNota4.TabIndex = 34;
			// 
			// txtBoxNota3
			// 
			this.txtBoxNota3.Location = new System.Drawing.Point(171, 119);
			this.txtBoxNota3.Margin = new System.Windows.Forms.Padding(2);
			this.txtBoxNota3.Name = "txtBoxNota3";
			this.txtBoxNota3.Size = new System.Drawing.Size(68, 20);
			this.txtBoxNota3.TabIndex = 35;
			// 
			// txtBoxNota2
			// 
			this.txtBoxNota2.Location = new System.Drawing.Point(171, 84);
			this.txtBoxNota2.Margin = new System.Windows.Forms.Padding(2);
			this.txtBoxNota2.Name = "txtBoxNota2";
			this.txtBoxNota2.Size = new System.Drawing.Size(68, 20);
			this.txtBoxNota2.TabIndex = 36;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 188);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(143, 13);
			this.label5.TabIndex = 39;
			this.label5.Text = "Informe a nota da 5° matéria:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(22, 155);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(143, 13);
			this.label6.TabIndex = 40;
			this.label6.Text = "Informe a nota da 4° matéria:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(23, 122);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(143, 13);
			this.label7.TabIndex = 41;
			this.label7.Text = "Informe a nota da 3° matéria:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(23, 87);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(143, 13);
			this.label8.TabIndex = 42;
			this.label8.Text = "Informe a nota da 2° matéria:";
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
			this.dataGVListar.Location = new System.Drawing.Point(36, 236);
			this.dataGVListar.Name = "dataGVListar";
			this.dataGVListar.RowHeadersWidth = 51;
			this.dataGVListar.Size = new System.Drawing.Size(752, 218);
			this.dataGVListar.TabIndex = 96;
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
			// btnMostrarFinalizados
			// 
			this.btnMostrarFinalizados.Location = new System.Drawing.Point(716, 25);
			this.btnMostrarFinalizados.Name = "btnMostrarFinalizados";
			this.btnMostrarFinalizados.Size = new System.Drawing.Size(75, 22);
			this.btnMostrarFinalizados.TabIndex = 97;
			this.btnMostrarFinalizados.Text = "Mostrar";
			this.btnMostrarFinalizados.UseVisualStyleBackColor = true;
			this.btnMostrarFinalizados.Click += new System.EventHandler(this.btnMostrar_Click);
			// 
			// lblMostrar
			// 
			this.lblMostrar.AutoSize = true;
			this.lblMostrar.Location = new System.Drawing.Point(566, 9);
			this.lblMostrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMostrar.Name = "lblMostrar";
			this.lblMostrar.Size = new System.Drawing.Size(225, 13);
			this.lblMostrar.TabIndex = 98;
			this.lblMostrar.Text = "Mostrar alunos que terminaram alguma materia";
			// 
			// lblAtrasados
			// 
			this.lblAtrasados.AutoSize = true;
			this.lblAtrasados.Location = new System.Drawing.Point(602, 50);
			this.lblAtrasados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblAtrasados.Name = "lblAtrasados";
			this.lblAtrasados.Size = new System.Drawing.Size(189, 13);
			this.lblAtrasados.TabIndex = 99;
			this.lblAtrasados.Text = "Mostrar aluno que pediram maior prazo";
			// 
			// btnMostrarAtrasado
			// 
			this.btnMostrarAtrasado.Location = new System.Drawing.Point(713, 72);
			this.btnMostrarAtrasado.Name = "btnMostrarAtrasado";
			this.btnMostrarAtrasado.Size = new System.Drawing.Size(75, 22);
			this.btnMostrarAtrasado.TabIndex = 100;
			this.btnMostrarAtrasado.Text = "Mostrar";
			this.btnMostrarAtrasado.UseVisualStyleBackColor = true;
			this.btnMostrarAtrasado.Click += new System.EventHandler(this.btnMostrarAtrasado_Click);
			// 
			// btnAlterarPrazo
			// 
			this.btnAlterarPrazo.Location = new System.Drawing.Point(713, 100);
			this.btnAlterarPrazo.Name = "btnAlterarPrazo";
			this.btnAlterarPrazo.Size = new System.Drawing.Size(75, 23);
			this.btnAlterarPrazo.TabIndex = 101;
			this.btnAlterarPrazo.Text = "Alterar Prazo";
			this.btnAlterarPrazo.UseVisualStyleBackColor = true;
			this.btnAlterarPrazo.Click += new System.EventHandler(this.btnAlterarPrazo_Click);
			// 
			// btnAtualizar
			// 
			this.btnAtualizar.Location = new System.Drawing.Point(713, 183);
			this.btnAtualizar.Name = "btnAtualizar";
			this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
			this.btnAtualizar.TabIndex = 102;
			this.btnAtualizar.Text = "Atualizar";
			this.btnAtualizar.UseVisualStyleBackColor = true;
			this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
			// 
			// LancamentodeNota
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAtualizar);
			this.Controls.Add(this.btnAlterarPrazo);
			this.Controls.Add(this.btnMostrarAtrasado);
			this.Controls.Add(this.lblAtrasados);
			this.Controls.Add(this.lblMostrar);
			this.Controls.Add(this.btnMostrarFinalizados);
			this.Controls.Add(this.dataGVListar);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtBoxNota2);
			this.Controls.Add(this.txtBoxNota3);
			this.Controls.Add(this.txtBoxNota4);
			this.Controls.Add(this.txtBoxNota5);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtBoxBuscaAluno);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnMenu);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBoxNota1);
			this.Controls.Add(this.btnDarNota);
			this.Name = "LancamentodeNota";
			this.Text = "Lancamento de Notas";
			((System.ComponentModel.ISupportInitialize)(this.dataGVListar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNota1;
        private System.Windows.Forms.Button btnDarNota;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxBuscaAluno;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBoxNota5;
        private System.Windows.Forms.TextBox txtBoxNota4;
        private System.Windows.Forms.TextBox txtBoxNota3;
        private System.Windows.Forms.TextBox txtBoxNota2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView dataGVListar;
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
		private System.Windows.Forms.Button btnMostrarFinalizados;
		private System.Windows.Forms.Label lblMostrar;
		private System.Windows.Forms.Label lblAtrasados;
		private System.Windows.Forms.Button btnMostrarAtrasado;
		private System.Windows.Forms.Button btnAlterarPrazo;
		private System.Windows.Forms.Button btnAtualizar;
	}
}