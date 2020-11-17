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
    public partial class ExcluirDadosAluno : Form
    {
        private List<Entidades.CadastroMatriculas> cadastroMatriculas;

        public ExcluirDadosAluno(List<Entidades.CadastroMatriculas> cadastroMatriculas)
        {
            InitializeComponent();
            this.cadastroMatriculas = cadastroMatriculas;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir seus dados?", "Atenção!" , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int ExcluirID = Convert.ToInt32(txtBoxID.Text);
                Entidades.CadastroMatriculas aluno = cadastroMatriculas.Find(Aluno => Aluno.ID == ExcluirID);
                cadastroMatriculas.Remove(aluno);

                MessageBox.Show("Seus dados foram permanentemente excluidos", "Exclusão");
                this.Close();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuAluno form = new MenuAluno();
            form.Show();
        }
    }
}
