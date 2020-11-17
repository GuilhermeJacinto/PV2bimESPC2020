using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova.Forms.Professor
{
    public partial class LancamentodeNota : Form
    {
        private List<Entidades.CadastroMatriculas> listaMatriculas;
        public String localArquivoMatricula = @"C:\temp\listaMatriculas.json";

        private Entidades.CadastroMatriculas aluno;
        public LancamentodeNota(List<Entidades.CadastroMatriculas> cadastroMatriculas)
        {
            InitializeComponent();
            this.listaMatriculas = cadastroMatriculas;
            mostrarAluno();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listaMatriculas = Communs.Files.lerArquivoUsuariosJSON(localArquivoMatricula);
            dataGVListar.Rows.Clear();
            foreach (var matricula in listaMatriculas)
            {
                if (Convert.ToInt32(txtBoxBuscaAluno.Text) == matricula.ID)
                {
                    dataGVListar.Rows.Add(matricula.ID, matricula.Nome, matricula.CPF, matricula.Materia1, matricula.Materia2, matricula.Materia3, matricula.Materia4, matricula.Materia5, matricula.Nota1, matricula.Nota2, matricula.Nota3, matricula.Nota4, matricula.Nota5, matricula.status1, matricula.status2, matricula.status3, matricula.status4, matricula.status5, matricula.datainicio, matricula.datafinal);
                }
            }
        }

        private void btnDarNota_Click(object sender, EventArgs e)
        {
            listaMatriculas = Communs.Files.lerArquivoUsuariosJSON(localArquivoMatricula);

			foreach (var matricula in listaMatriculas)
			{
                if(Convert.ToInt32(txtBoxBuscaAluno.Text) == matricula.ID)
				{
					if (!string.IsNullOrEmpty(txtBoxNota1.Text))
					{
                        matricula.Nota1 = Convert.ToInt32(txtBoxNota1.Text);
                        matricula.status1 = "Corrigida";
					}
                    if (!string.IsNullOrEmpty(txtBoxNota2.Text))
                    {
                        matricula.Nota2 = Convert.ToInt32(txtBoxNota2.Text);
                        matricula.status2 = "Corrigida";
                    }
                    if (!string.IsNullOrEmpty(txtBoxNota3.Text))
                    {
                        matricula.Nota3 = Convert.ToInt32(txtBoxNota3.Text);
                        matricula.status3 = "Corrigida";
                    }
                    if (!string.IsNullOrEmpty(txtBoxNota4.Text))
                    {
                        matricula.Nota4 = Convert.ToInt32(txtBoxNota4.Text);
                        matricula.status4 = "Corrigida";
                    }
                    if (!string.IsNullOrEmpty(txtBoxNota5.Text))
                    {
                        matricula.Nota5 = Convert.ToInt32(txtBoxNota5.Text);
                        matricula.status5 = "Corrigida";
                    }
                }
			}
            Communs.Files.salvaMatriculoJSON(localArquivoMatricula, listaMatriculas);




        }

        private void mostrarAluno()
		{
            dataGVListar.Rows.Clear();
            listaMatriculas = Communs.Files.lerArquivoUsuariosJSON(localArquivoMatricula);
			foreach (var matricula in listaMatriculas)
			{
                    dataGVListar.Rows.Add(matricula.ID, matricula.Nome, matricula.CPF, matricula.Materia1, matricula.Materia2, matricula.Materia3, matricula.Materia4, matricula.Materia5, matricula.Nota1, matricula.Nota2, matricula.Nota3, matricula.Nota4, matricula.Nota5, matricula.status1, matricula.status2, matricula.status3, matricula.status4, matricula.status5, matricula.datainicio, matricula.datafinal);     
            }
            
        }

		private void btnMostrar_Click(object sender, EventArgs e)
		{
            dataGVListar.Rows.Clear();
            listaMatriculas = Communs.Files.lerArquivoUsuariosJSON(localArquivoMatricula);
            foreach (var matricula in listaMatriculas)
            {
				if (matricula.status1 == "Finalizada" || matricula.status2 == "Finalizada" || matricula.status3 == "Finalizada" || matricula.status4 == "Finalizada" || matricula.status5 == "Finalizada")
				{
                    dataGVListar.Rows.Add(matricula.ID, matricula.Nome, matricula.CPF, matricula.Materia1, matricula.Materia2, matricula.Materia3, matricula.Materia4, matricula.Materia5, matricula.Nota1, matricula.Nota2, matricula.Nota3, matricula.Nota4, matricula.Nota5, matricula.status1, matricula.status2, matricula.status3, matricula.status4, matricula.status5, matricula.datainicio, matricula.datafinal);
                }
                
            }
        }

		private void btnMostrarAtrasado_Click(object sender, EventArgs e)
		{
            dataGVListar.Rows.Clear();
            listaMatriculas = Communs.Files.lerArquivoUsuariosJSON(localArquivoMatricula);
            foreach (var matricula in listaMatriculas)
            {
                if (matricula.status1 == "Mudar Prazo" || matricula.status2 == "Mudar Prazo" || matricula.status3 == "Mudar Prazo" || matricula.status4 == "Mudar Prazo" || matricula.status5 == "Mudar Prazo")
                {
                    dataGVListar.Rows.Add(matricula.ID, matricula.Nome, matricula.CPF, matricula.Materia1, matricula.Materia2, matricula.Materia3, matricula.Materia4, matricula.Materia5, matricula.Nota1, matricula.Nota2, matricula.Nota3, matricula.Nota4, matricula.Nota5, matricula.status1, matricula.status2, matricula.status3, matricula.status4, matricula.status5, matricula.datainicio, matricula.datafinal);
                }

            }
        }

        private void btnAlterarPrazo_Click(object sender, EventArgs e)
        {
            listaMatriculas = Communs.Files.lerArquivoUsuariosJSON(localArquivoMatricula);
            foreach (var matricula in listaMatriculas)
            {
                if (Convert.ToInt32(txtBoxBuscaAluno.Text) == matricula.ID)
                {
                    DateTime data = DateTime.Parse(matricula.datafinal);
                    DateTime data2 = data.AddDays(7);
                    matricula.datafinal = String.Format(data2.ToString("dd/MM/yyyy"));
					if (matricula.status1 == "Mudar Prazo")
					{
                        matricula.status1 = "Prazo Prorrogado";
					}
                    if (matricula.status2 == "Mudar Prazo")
                    {
                        matricula.status2 = "Prazo Prorrogado";
                    }
                    if (matricula.status3 == "Mudar Prazo")
                    {
                        matricula.status3 = "Prazo Prorrogado";
                    }
                    if (matricula.status4 == "Mudar Prazo")
                    {
                        matricula.status4 = "Prazo Prorrogado";
                    }
                    if (matricula.status5 == "Mudar Prazo")
                    {
                        matricula.status5 = "Prazo Prorrogado";
                    }
                    Communs.Files.salvaMatriculoJSON(localArquivoMatricula, listaMatriculas);
                }
            }
        }

		private void btnAtualizar_Click(object sender, EventArgs e)
		{
            dataGVListar.Rows.Clear();
            listaMatriculas = Communs.Files.lerArquivoUsuariosJSON(localArquivoMatricula);
            foreach (var matricula in listaMatriculas)
            {
                    dataGVListar.Rows.Add(matricula.ID, matricula.Nome, matricula.CPF, matricula.Materia1, matricula.Materia2, matricula.Materia3, matricula.Materia4, matricula.Materia5, matricula.Nota1, matricula.Nota2, matricula.Nota3, matricula.Nota4, matricula.Nota5, matricula.status1, matricula.status2, matricula.status3, matricula.status4, matricula.status5, matricula.datainicio, matricula.datafinal);
}
        }
	}
}
