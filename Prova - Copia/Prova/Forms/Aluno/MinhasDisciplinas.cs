using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prova.Entidades;
using Prova.Communs;

namespace Prova.Forms
{
    public partial class MinhasDisciplinas : Form
    {
        private List<CadastroMatriculas> cadastroMatriculas;
        public String localArquivoMatricula = @"C:\temp\listaMatriculas.json";

        public MinhasDisciplinas(List<CadastroMatriculas> cadastroMatriculas)
        {
            InitializeComponent();
            this.cadastroMatriculas = cadastroMatriculas;
            desabilitartxtMaterias();
        }

        private void MinhasDisciplinas_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            cadastroMatriculas = Communs.Files.lerArquivoUsuariosJSON(localArquivoMatricula);
            dataGVListar.Rows.Clear();

			foreach (var matricula in cadastroMatriculas)
			{
                
                if(Convert.ToInt32(txtBoxID.Text) == matricula.ID)
				{
                    //Aparce valores no DataGrid
                    dataGVListar.Rows.Add(matricula.ID, matricula.Nome, matricula.CPF, matricula.Materia1, matricula.Materia2, matricula.Materia3, matricula.Materia4, matricula.Materia5, matricula.Nota1, matricula.Nota2, matricula.Nota3, matricula.Nota4, matricula.Nota5, matricula.status1, matricula.status2, matricula.status3, matricula.status4, matricula.status5, matricula.datainicio, matricula.datafinal);
                    //Aparece valores nos combobox
                    txtBoxMateria1.Text = matricula.Materia1;
                    txtBoxMateria2.Text = matricula.Materia2;
                    txtBoxMateria3.Text = matricula.Materia3;
                    txtBoxMateria4.Text = matricula.Materia4;
                    txtBoxMateria5.Text = matricula.Materia5;
                    //aparece valores nas notas
                    lblNotaMateria1.Text =  matricula.Nota1.ToString();
                    lblNotaMateria2.Text =  matricula.Nota2.ToString();
                    lblNotaMateria3.Text =  matricula.Nota3.ToString();
                    lblNotaMateria4.Text =  matricula.Nota4.ToString();
                    lblNotaMateria5.Text =  matricula.Nota5.ToString();
                    //aparece valores status
                    lblResultadoStatus1.Text = matricula.status1;
                    lblResultadoStatus2.Text = matricula.status2;
                    lblResultadoStatus3.Text = matricula.status3;
                    lblResultadoStatus4.Text = matricula.status4;
                    lblResultadoStatus5.Text = matricula.status5;
                }
			}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Forms.Aluno.MenuAluno form = new Forms.Aluno.MenuAluno();
            form.Show();
        }

		private void txtBoxNome_TextChanged(object sender, EventArgs e)
		{

		}
        
        private void desabilitartxtMaterias()
		{
            txtBoxMateria1.Enabled = false;
            txtBoxMateria2.Enabled = false;
            txtBoxMateria3.Enabled = false;
            txtBoxMateria4.Enabled = false;
            txtBoxMateria5.Enabled = false;
		}


	}
}
