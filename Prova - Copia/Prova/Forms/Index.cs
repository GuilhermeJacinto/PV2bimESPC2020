using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prova.Entidades;
using Prova.Forms;
using Prova.Communs;
using Prova.Entidades;

namespace Prova
{
    public partial class Index : Form
    {
        private List<CadastroMatriculas> ListarMatricula;
        public String local = @"C:\temp\listaMatriculas.json";

        public Index()
        {
            InitializeComponent();
            ListarMatricula = new List<CadastroMatriculas>();
            ValidarData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            Forms.Matricula forms = new Forms.Matricula(ListarMatricula);
            forms.Show();
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            Forms.Materia formMaterias = new Forms.Materia(ListarMatricula);
            formMaterias.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.Materia formMaterias = new Forms.Materia(ListarMatricula);
            formMaterias.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forms.Professor.LancamentodeNota form = new Forms.Professor.LancamentodeNota(ListarMatricula);
            form.Show();
        }

        private void ValidarData()
        {
            String Horalocal = (DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString());


            ListarMatricula = Communs.Files.lerArquivoUsuariosJSON(local);
            foreach (var verificarData in ListarMatricula)
            {
                if (Convert.ToDateTime(verificarData.datafinal) < Convert.ToDateTime(Horalocal))
                {
                    if (verificarData.status1 == "Cursando")
                    {
                        verificarData.status1 = "Não concluído";
                        //MessageBox.Show("Entrou na etapa 1");
                    }
                    if (verificarData.status2 == "Cursando")
                    {
                        verificarData.status2 = "Não concluído";
                    }
                    if (verificarData.status3 == "Cursando")
                    {
                        verificarData.status3 = "Não concluído";
                    }
                    if (verificarData.status4 == "Cursando")
                    {
                        verificarData.status4 = "Não concluído";
                    }
                    if (verificarData.status5 == "Cursando")
                    {
                        verificarData.status5 = "Não concluído";
                    }

                }
                else { 
                
                }
                Communs.Files.salvaMatriculoJSON(local, ListarMatricula);
            }
        }
    }
}
