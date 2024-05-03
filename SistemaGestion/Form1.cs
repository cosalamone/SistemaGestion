namespace SistemaGestion
{
    public partial class form_login : Form
    {
        Administracion administracion;
        List<Usuario> usuarios;
        public form_login()
        {
            InitializeComponent();
            this.usuarios = new List<Usuario>();
            this.administracion = new Administracion();


        }
        private void form_login_Load(object sender, EventArgs e)
        {
            administracion.AgregarUsuarios(new Usuario("maria", "123"));
            administracion.AgregarUsuarios(new Usuario("ana", "456"));
            administracion.AgregarUsuarios(new Usuario("pablo", "789"));
            administracion.AgregarUsuarios(new Usuario("juan", "asd"));

        }
        private void btn_login_Click(object sender, EventArgs e)
        {

            string usuario = this.txt_login_user.Text; // obtengo input;
            string contrasenia = this.txt_login_password.Text;


            foreach (var user in administracion.Usuarios)
            {
                if (user.UserName == usuario && user.Contrasenia == contrasenia)
                {
                    label_login_error.Text = usuario;
                }
                else
                {
                    label_login_error.Visible = true;
                }
            }


        }


    }
}
