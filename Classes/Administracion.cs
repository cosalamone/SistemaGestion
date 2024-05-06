namespace SistemaGestion
{
    public class Administracion
    {
        public List<Usuario> usuarios;
        public List<Usuario> alumnos;

        public Administracion()
        {
            this.usuarios = new List<Usuario>();
            this.alumnos = new List<Usuario>();
        }

        public void AgregarUsuarios(Usuario user)
        {
            this.usuarios.Add(user);
        }

        public List<Usuario> Usuarios
        {
            get { return this.usuarios; }
        }

        public void AgregarAlumnos(Usuario alumno)
        {
            this.alumnos.Add(alumno);
        }

        public List<Usuario> Alumnos
        {
            get { return this.alumnos; }
        }

        public List<Usuario> Filter(List<Usuario> alumnos, int value)
        {
            List<Usuario> alumnosFiltrados = new List<Usuario>(); ;

            foreach (var alumno in alumnos)
            {
                if (value == 1 && alumno.Activo == true)
                {
                    alumnosFiltrados.Add(alumno);
                }
                else if (value == 0 && alumno.Activo == false)
                {
                    alumnosFiltrados.Add(alumno);

                }
                else if (value == -1)
                {
                    alumnosFiltrados.Add(alumno);

                }

            }

            return alumnosFiltrados;

        }
    }
}
