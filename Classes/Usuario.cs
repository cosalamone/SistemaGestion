namespace SistemaGestion
{
    public class Usuario
    {
        private string _userName;
        private string _contrasenia;
        private string _rol;
        public Usuario(string userName, string contrasenia)
        {
            this._userName = userName;
            this._contrasenia = contrasenia;
        }

        public Usuario(string userName, string contrasenia, string rol) : this(userName, contrasenia)
        {
            this._rol = rol;
        }

        public string UserName { get { return _userName; } }
        public string Contrasenia { get { return _contrasenia; } }
        public string Rol { get { return _rol; } }
    }
}
