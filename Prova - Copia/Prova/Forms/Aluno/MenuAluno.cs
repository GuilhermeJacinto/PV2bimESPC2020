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
    public partial class MenuAluno : Form
    {
        
        public MenuAluno()
        {
            InitializeComponent();          
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Index form = new Index();
            form.Show();
        }

        private void btnFormAlterar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
