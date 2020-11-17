using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova.Forms.Aluno
{
    public partial class VerAlunos : Form
    {
        public VerAlunos(List<Entidades.CadastroMatriculas> cadastroMatriculas)
        {
            InitializeComponent();           
            mostrarAlunos(cadastroMatriculas);
        }
        private void mostrarAlunos(List<Entidades.CadastroMatriculas> cadastroMatriculas)
        {
            cadastroMatriculas.ForEach(aluno => dataGridDados.DataSource = cadastroMatriculas);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuAluno form = new MenuAluno();
            form.Show();
        }
    }
}
