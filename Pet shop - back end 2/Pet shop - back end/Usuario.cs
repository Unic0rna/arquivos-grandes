using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_shop___back_end
{
    

    public class Usuario
    {
        public Usuario(string email, string senha, string cliente)
        {
            Email = email;
            Senha = senha;
            TipoUsuario = cliente;
        }

        public string Email { get; set; }
        public string Senha { get; set; }

        public string TipoUsuario { get; set; }
    }
}
