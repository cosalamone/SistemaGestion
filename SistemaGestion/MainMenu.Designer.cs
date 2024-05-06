namespace SistemaGestion
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            menuStrip1 = new MenuStrip();
            menúPrincipalToolStripMenuItem = new ToolStripMenuItem();
            gestionDeAlumnoToolStripMenuItem = new ToolStripMenuItem();
            grid_gestionAlumnos = new DataGridView();
            label_gestionAlumnos = new Label();
            cbox_gestion_alumno_filtro_activo = new ComboBox();
            btn_buscar = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_gestionAlumnos).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menúPrincipalToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menúPrincipalToolStripMenuItem
            // 
            menúPrincipalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionDeAlumnoToolStripMenuItem });
            menúPrincipalToolStripMenuItem.Name = "menúPrincipalToolStripMenuItem";
            menúPrincipalToolStripMenuItem.Size = new Size(121, 24);
            menúPrincipalToolStripMenuItem.Text = "Menú Principal";
            // 
            // gestionDeAlumnoToolStripMenuItem
            // 
            gestionDeAlumnoToolStripMenuItem.Name = "gestionDeAlumnoToolStripMenuItem";
            gestionDeAlumnoToolStripMenuItem.Size = new Size(219, 26);
            gestionDeAlumnoToolStripMenuItem.Text = "Gestion de Alumno";
            gestionDeAlumnoToolStripMenuItem.Click += gestionDeAlumnoToolStripMenuItem_Click;
            // 
            // grid_gestionAlumnos
            // 
            grid_gestionAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_gestionAlumnos.Location = new Point(24, 131);
            grid_gestionAlumnos.Name = "grid_gestionAlumnos";
            grid_gestionAlumnos.RowHeadersWidth = 51;
            grid_gestionAlumnos.Size = new Size(746, 188);
            grid_gestionAlumnos.TabIndex = 1;
            grid_gestionAlumnos.Visible = false;
            // 
            // label_gestionAlumnos
            // 
            label_gestionAlumnos.AutoSize = true;
            label_gestionAlumnos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_gestionAlumnos.Location = new Point(278, 55);
            label_gestionAlumnos.Name = "label_gestionAlumnos";
            label_gestionAlumnos.Size = new Size(226, 31);
            label_gestionAlumnos.TabIndex = 2;
            label_gestionAlumnos.Text = "Gestion de alumnos";
            // 
            // cbox_gestion_alumno_filtro_activo
            // 
            cbox_gestion_alumno_filtro_activo.FormattingEnabled = true;
            cbox_gestion_alumno_filtro_activo.Location = new Point(24, 97);
            cbox_gestion_alumno_filtro_activo.Name = "cbox_gestion_alumno_filtro_activo";
            cbox_gestion_alumno_filtro_activo.Size = new Size(151, 28);
            cbox_gestion_alumno_filtro_activo.TabIndex = 3;
            cbox_gestion_alumno_filtro_activo.Visible = false;
            cbox_gestion_alumno_filtro_activo.SelectedIndexChanged += cbox_gestion_alumno_filtro_activo_SelectedIndexChanged;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(181, 97);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(95, 28);
            btn_buscar.TabIndex = 4;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Visible = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_buscar);
            Controls.Add(cbox_gestion_alumno_filtro_activo);
            Controls.Add(label_gestionAlumnos);
            Controls.Add(grid_gestionAlumnos);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_gestionAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menúPrincipalToolStripMenuItem;
        private ToolStripMenuItem gestionDeAlumnoToolStripMenuItem;
        private DataGridView grid_gestionAlumnos;
        private Label label_gestionAlumnos;
        private ComboBox cbox_gestion_alumno_filtro_activo;
        private Button btn_buscar;
    }
}