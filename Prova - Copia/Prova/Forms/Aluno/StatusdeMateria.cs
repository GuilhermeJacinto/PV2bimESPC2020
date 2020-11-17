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

namespace Prova.Forms.Aluno
{
    public partial class StatusdeMateria : Form
    {
        private List<CadastroMatriculas> listaMatriculas;
        public String localArquivoMatricula = @"C:\temp\listaMatriculas.json";
        public StatusdeMateria(List<CadastroMatriculas> cadastroMatriculas)
        {
            InitializeComponent();
            this.listaMatriculas = cadastroMatriculas;
            txbNome.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            cbxMaterias.Items.Clear();

            listaMatriculas = Communs.Files.lerArquivoUsuariosJSON(localArquivoMatricula);
            foreach(var matricula in listaMatriculas)
			{
                if(Convert.ToInt32(txtBoxID.Text) == matricula.ID)
				{
                    txbNome.Text = matricula.Nome;
                    cbxMaterias.Items.Add(matricula.Materia1);
                    cbxMaterias.Items.Add(matricula.Materia2);
                    cbxMaterias.Items.Add(matricula.Materia3);
                    cbxMaterias.Items.Add(matricula.Materia4);
                    cbxMaterias.Items.Add(matricula.Materia5);
                    MessageBox.Show("Usuário encontrado");
				}
			}
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuAluno form = new MenuAluno();
            form.Show();
        }

		private void btnFinalizar_Click(object sender, EventArgs e)
		{
			foreach (var materia in listaMatriculas)
			{

				if (Convert.ToInt32(txtBoxID.Text) == materia.ID)
				{
                    if (cbxMaterias.SelectedIndex == 0)
                    {
                        materia.status1 = "Finalizada";
                    }
                    else if (cbxMaterias.SelectedIndex == 1)
                    {
                        materia.status2 = "Finalizada";
                    }
                    else if (cbxMaterias.SelectedIndex == 2)
                    {
                        materia.status3 = "Finalizada";
                    }
                    else if (cbxMaterias.SelectedIndex == 3)
                    {
                        materia.status4 = "Finalizada";
                    }
                    else if (cbxMaterias.SelectedIndex == 4)
                    {
                        materia.status5 = "Finalizada";
                    }
                    Communs.Files.salvaMatriculoJSON(localArquivoMatricula, listaMatriculas);
                    MessageBox.Show("Materia finalizada, aguarde o professor lançar a nota");
                }
                
            }
			
		}

		private void btnTempo_Click(object sender, EventArgs e)
		{
            foreach (var materia in listaMatriculas)
            {

                if (Convert.ToInt32(txtBoxID.Text) == materia.ID)
                {
                    if (cbxMaterias.SelectedIndex == 0)
                    {
                        materia.status1 = "Mudar Prazo";
                    }
                    else if (cbxMaterias.SelectedIndex == 1)
                    {
                        materia.status2 = "Mudar Prazo";
                    }
                    else if (cbxMaterias.SelectedIndex == 2)
                    {
                        materia.status3 = "Mudar Prazo";
                    }
                    else if (cbxMaterias.SelectedIndex == 3)
                    {
                        materia.status4 = "Mudar Prazo";
                    }
                    else if (cbxMaterias.SelectedIndex == 4)
                    {
                        materia.status5 = "Mudar Prazo";
                    }
                    Communs.Files.salvaMatriculoJSON(localArquivoMatricula, listaMatriculas);
                    MessageBox.Show("Pedido de prazo solicitado, aguarde resposta do professor");
                }

            }
        }
	}
}
