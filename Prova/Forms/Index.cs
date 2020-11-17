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

namespace Prova
{
    public partial class Index : Form
    {
        private List<CadastroMatriculas> ListarMatricula;
        public Index()
        {
            InitializeComponent();
            ListarMatricula = new List<CadastroMatriculas>();
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
    }
}
