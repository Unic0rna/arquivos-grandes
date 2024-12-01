using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Pet_shop___back_end
{
    public class ReadUsuario
    {
        string caminho = @"C:\Pet shop - back end 2\Pet shop - back end\Login.txt";

        public List<Usuario> BuscaUsuarios()
        {
            string linha;
            List<Usuario> listaUsuarios = new List<Usuario>();

            using (StreamReader sr = new StreamReader(caminho))
            {
                while ((linha = sr.ReadLine()) != null)
                {

                    var campos = linha.Split(';');
                    var usu = new Usuario(campos[0], campos[1], campos[2]);

                    listaUsuarios.Add(usu);
                }

            }
            return listaUsuarios;
        }
    }
}
