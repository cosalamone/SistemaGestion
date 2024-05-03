using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion
{
    public class Administracion
    {
        public List<Usuario> usuarios;

        public Administracion()
        {
            this.usuarios = new List<Usuario>();
        }

        public void AgregarUsuarios(Usuario user) {
            this.usuarios.Add(user);
        }

        public List<Usuario> Usuarios { 
            get { return this.usuarios; }
        }
    }
}
