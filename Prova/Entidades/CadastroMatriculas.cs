using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Entidades
{
    public class CadastroMatriculas
    {
        public int ID { get; set; }
        public String Nome { get; set; }
        public String CPF { get; set; }

        public String Materia1 { get; set; }
        public String Materia2 { get; set; }
        public String Materia3 { get; set; }
        public String Materia4 { get; set; }
        public String Materia5 { get; set; }

        public float Nota1 { get; set; }
        public float Nota2 { get; set; }
        public float Nota3 { get; set; }
        public float Nota4 { get; set; }
        public float Nota5 { get; set; }

        public String status1 { get; set; }
        public String status2 { get; set; }
        public String status3 { get; set; }
        public String status4 { get; set; }
        public String status5 { get; set; }

        public String datainicio { get; set; }
        public String datafinal { get; set; }


    }
}
