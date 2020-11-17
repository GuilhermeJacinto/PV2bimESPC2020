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
using System.IO;

namespace Prova.Forms
{
    public partial class Matricula : Form
    {
        private List<CadastroMatriculas> listarMatriculas;

        public String localArquivoMatricula = @"C:\Prova\listaMatriculas.json";
        public Matricula(List<CadastroMatriculas> listarMatriculas)
        {
            InitializeComponent();
            this.listarMatriculas = listarMatriculas;
            MostarData();
  
            txbInicio.Enabled = false;
            txbFinal.Enabled = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
			if (File.Exists(localArquivoMatricula))
			{
                listarMatriculas = Communs.Files.lerArquivoUsuariosJSON(localArquivoMatricula);
                CadastroMatriculas umaMatricula = getMatericulas();
                listarMatriculas.Add(umaMatricula);
                Communs.Files.salvaMatriculoJSON(localArquivoMatricula, listarMatriculas);
			}
			else
			{
                CadastroMatriculas umaMatricula = getMatericulas();
                listarMatriculas.Add(umaMatricula);
                Communs.Files.salvaMatriculoJSON(localArquivoMatricula, listarMatriculas);
            }
            MessageBox.Show("Usuário Cadastrado com Sucesso");
           
            dataGVListar.DataSource = null;
            dataGVListar.DataSource = listarMatriculas;

        }
        private void MostarData()
        {
            txbInicio.AppendText(DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString());
            txbFinal.AppendText(DateTime.Now.AddDays(7).ToString("dd/MM/yyyy"));
        }
        private void LimparCampo()
        {
            txbAluno.Clear();
            txbCPF.Clear();
            txbMatricula1.Clear();
            txbMatricula2.Clear();
            txbMatricula3.Clear();
            txbMatricula4.Clear();
            txbMatricula5.Clear();
        }
        private int ContagemList(List<CadastroMatriculas> listarMatricula)
        {
            int contagem = listarMatricula.Count();
            return contagem;
        }

        private void dataGVListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private CadastroMatriculas getMatericulas()
		{
            CadastroMatriculas cadastro = new CadastroMatriculas();
            cadastro.ID = verificaID();
            cadastro.Nome = txbAluno.Text;
            cadastro.CPF = txbCPF.Text;
            cadastro.Materia1 = txbMatricula1.Text;
            cadastro.Materia2 = txbMatricula2.Text;
            cadastro.Materia3 = txbMatricula3.Text;
            cadastro.Materia4 = txbMatricula4.Text;
            cadastro.Materia5 = txbMatricula5.Text;
            if(string.IsNullOrEmpty(txbMatricula1.Text))
			{
                cadastro.status1 = "";
            }
			else
			{
                cadastro.status1 = "Cursando";
            }
            if(string.IsNullOrEmpty(txbMatricula2.Text))
			{
                cadastro.status2 = "";
            }
			else
			{
                cadastro.status2 = "Cursando";
            }
            if(string.IsNullOrEmpty(txbMatricula3.Text))
			{
                cadastro.status3 = "";
            }
			else
			{
                cadastro.status3 = "Cursando";
            }
            if(string.IsNullOrEmpty(txbMatricula4.Text))
			{
                cadastro.status4 = "";
            }
			else
			{
                cadastro.status4 = "Cursando";
            }
            if(string.IsNullOrEmpty(txbMatricula5.Text))
			{
                cadastro.status5 = "";
            }
			else
			{
                cadastro.status5 = "Cursando";
            }
            cadastro.datainicio = txbInicio.Text;
            cadastro.datafinal = txbFinal.Text;
            return cadastro;
        }

        private int verificaID()
		{
            int contagem = 1;
            int novoID = 0;

            foreach (var matricula in listarMatriculas)
			{
				if (listarMatriculas.Count == contagem)
				{
                    novoID = matricula.ID + 1;
				}
                contagem++;
			}
            return novoID;
        }


    }
}
