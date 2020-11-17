using Prova.Entidades;
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
using Prova.Forms.Aluno;
using Prova.Forms;
using Prova.Communs;

namespace Prova.Forms
{
    public partial class Materia : Form
    {
        private List<CadastroMatriculas> cadastroMatriculas;
        public String localArquivoMatricula = @"C:\Prova\listaMatriculas.json";

        public Materia(List<CadastroMatriculas> cadastroMatriculas)
        {
            InitializeComponent();
            this.cadastroMatriculas = cadastroMatriculas;
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            cadastroMatriculas = Communs.Files.lerArquivoUsuariosJSON(localArquivoMatricula);
            dataGVListar.Rows.Clear();
            foreach(var matricula in cadastroMatriculas)
			{
                if(txbProcurarNome.Text == matricula.Nome)
				{
                    dataGVListar.Rows.Add(matricula.ID, matricula.Nome, matricula.CPF, matricula.Materia1, matricula.Materia2, matricula.Materia3, matricula.Materia4, matricula.Materia5, matricula.Nota1, matricula.Nota2, matricula.Nota3, matricula.Nota4, matricula.Nota5, matricula.status1, matricula.status2, matricula.status3, matricula.status4, matricula.status5, matricula.datainicio, matricula.datafinal);
                    richTextBoxListar.Clear();
                    richTextBoxListar.AppendText(matricula.Nome);
				}
			}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.MinhasDisciplinas formdisciplinas = new Forms.MinhasDisciplinas(cadastroMatriculas);
            formdisciplinas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.Aluno.StatusdeMateria formStatus = new Forms.Aluno.StatusdeMateria(cadastroMatriculas);
            formStatus.Show();
        }

        private void dataGVListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
