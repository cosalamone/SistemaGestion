using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion
{
    public class Usuario
    {
        private string _userName;
        private string _contrasenia;

        public Usuario(string userName, string contrasenia)
        {
            this._userName = userName;
            this._contrasenia = contrasenia;
        }

        public string UserName {  get { return _userName; } }
        public string Contrasenia { get { return _contrasenia; } }
    }
}
