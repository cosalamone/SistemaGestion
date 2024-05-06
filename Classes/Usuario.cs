namespace SistemaGestion
{
    public class Usuario
    {
        private string _userName;
        private string _contrasenia;
        private string _rol;
        private string _nombre;
        private string _apellido;
        private string _dni;
        private string _telefono;
        private bool _activo;
        public Usuario(string userName, string contrasenia)
        {
            this._userName = userName;
            this._contrasenia = contrasenia;
        }

        public Usuario(string userName, string contrasenia, string rol) : this(userName, contrasenia)
        {
            this._rol = rol;
        }

        public Usuario(string nombre, string apellido, string dni, string rol, bool activo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
            this._telefono = rol;
            this._activo = activo;
        }

        public string UserName { get { return _userName; } }

        public string Contrasenia { get { return _contrasenia; } }

        public string Rol { get { return _rol; } }

        public string Nombre { get { return _nombre; } }

        public string Apellido { get { return _apellido; } }

        public string Dni { get { return _dni; } }

        public string Telefono { get { return _telefono; } }

        public bool Activo { get { return _activo; } }


    }
}
