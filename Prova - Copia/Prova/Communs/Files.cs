using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Prova.Entidades;

namespace Prova.Communs
{
	class Files
	{
        public static void salvaMatriculoJSON(String arquivo, List<CadastroMatriculas> listamatricula)
        {
            StreamWriter file = new StreamWriter(arquivo);
            listamatricula.ForEach(pessoa =>
            {
                string output = JsonConvert.SerializeObject(pessoa);
                file.WriteLine(output);
            });
            file.Close();
        }
        public static List<CadastroMatriculas> lerArquivoUsuariosJSON(String arquivo)
        {
            string line;
            List<CadastroMatriculas> listaUsuarios = new List<CadastroMatriculas>();

            StreamReader file = new StreamReader(arquivo);
            while ((line = file.ReadLine()) != null)
            {
                CadastroMatriculas umaMatricula = JsonConvert.DeserializeObject<CadastroMatriculas>(line);
                listaUsuarios.Add(umaMatricula);
            }

            file.Close();
            return listaUsuarios;
        }
    }
}
