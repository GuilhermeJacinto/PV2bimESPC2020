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

namespace Prova.Forms
{
    public partial class Lista : Form
    {
        public Lista(List<CadastroMatriculas> cadastroMatriculas)
        {
            InitializeComponent();
            MostraMatriculas(cadastroMatriculas);
        }
        private void MostraMatriculas(List<CadastroMatriculas> cadastroMatriculas)
        {
            cadastroMatriculas.ForEach(pessoas =>
            {
                richTextBoxPacientes.AppendText(pessoas.ToString());
            });
        }

        private void richTextBoxPacientes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
