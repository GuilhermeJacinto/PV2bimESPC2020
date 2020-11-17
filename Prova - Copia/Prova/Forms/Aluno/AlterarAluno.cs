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
    public partial class AlterarAluno : Form
    {
        private List<Entidades.CadastroMatriculas> cadastroMatriculas;

        private Entidades.CadastroMatriculas aluno;

        public AlterarAluno(List<Entidades.CadastroMatriculas> cadastroMatriculas)
        {
            InitializeComponent();
            this.cadastroMatriculas = cadastroMatriculas;
            mostrarAlunos(cadastroMatriculas);
        }

        private void mostrarAlunos(List<Entidades.CadastroMatriculas> cadastroMatriculas)
        {
            cadastroMatriculas.ForEach(aluno => dataGridDados.DataSource = cadastroMatriculas);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int buscaID = Convert.ToInt32(txtBoxID.Text);
            aluno = cadastroMatriculas.Find(Aluno => Aluno.ID == buscaID);
            txtBoxNovoNome.Text = aluno.Nome;
            txtBoxNovoCPF.Text = aluno.CPF;
        }

        private void btnAtualizaDados_Click(object sender, EventArgs e)
        {
            aluno.Nome = txtBoxNovoNome.Text;
            aluno.CPF = txtBoxNovoCPF.Text;

            mostrarAlunos(cadastroMatriculas);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuAluno form = new MenuAluno();
            form.Show();
        }
    }
}
