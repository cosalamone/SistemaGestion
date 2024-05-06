using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion
{

    public partial class MainMenu : Form
    {
        Administracion administracion;
        List<Usuario> alumnos;
        public MainMenu()
        {
            InitializeComponent();
            this.alumnos = new List<Usuario>();
            this.administracion = new Administracion();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            administracion.AgregarAlumnos(new Usuario("Carlos", "Perez", "33657755", "alumno", true));
            administracion.AgregarAlumnos(new Usuario("Paulina", "Ferrero", "44552244", "alumno", false));
            this.cbox_gestion_alumno_filtro_activo.DataSource = Enum.GetValues(typeof(EActivoFiltro));

        }

        private void gestionDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grid_gestionAlumnos.Visible = true;
            grid_gestionAlumnos.DataSource = administracion.alumnos;

            cbox_gestion_alumno_filtro_activo.Visible = true;
            btn_buscar.Visible = true;
        }

        private void cbox_gestion_alumno_filtro_activo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            EActivoFiltro filtroActivoSeleccionado = (EActivoFiltro)cbox_gestion_alumno_filtro_activo.SelectedValue;
            int valorFiltrado = procesarFiltroActivo(filtroActivoSeleccionado);
            grid_gestionAlumnos.DataSource = null;
            grid_gestionAlumnos.DataSource = administracion.Filter(administracion.alumnos, valorFiltrado);

        }

        private int procesarFiltroActivo(EActivoFiltro filtroActivoSeleccionado) {
            if (filtroActivoSeleccionado == EActivoFiltro.activo)
            {
                return 1;

            }
            else if (filtroActivoSeleccionado == EActivoFiltro.inactivo)
            {
                return 0;

            }
            else {
                return -1;
            }
        }

    }
}
