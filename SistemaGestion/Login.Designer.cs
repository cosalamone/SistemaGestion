namespace SistemaGestion
{
    partial class form_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lablel_utn = new Label();
            label_login = new Label();
            txt_login_user = new TextBox();
            txt_login_password = new TextBox();
            btn_login = new Button();
            label_login_error = new Label();
            SuspendLayout();
            // 
            // lablel_utn
            // 
            lablel_utn.AutoSize = true;
            lablel_utn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lablel_utn.Location = new Point(269, 31);
            lablel_utn.Name = "lablel_utn";
            lablel_utn.Size = new Size(245, 41);
            lablel_utn.TabIndex = 0;
            lablel_utn.Text = "UNT Avellaneda";
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_login.Location = new Point(358, 100);
            label_login.Name = "label_login";
            label_login.Size = new Size(71, 31);
            label_login.TabIndex = 1;
            label_login.Text = "Login";
            // 
            // txt_login_user
            // 
            txt_login_user.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_login_user.Location = new Point(324, 153);
            txt_login_user.Name = "txt_login_user";
            txt_login_user.Size = new Size(125, 27);
            txt_login_user.TabIndex = 2;
            txt_login_user.Text = "Usuario";
            // 
            // txt_login_password
            // 
            txt_login_password.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_login_password.Location = new Point(324, 199);
            txt_login_password.Name = "txt_login_password";
            txt_login_password.Size = new Size(125, 27);
            txt_login_password.TabIndex = 3;
            txt_login_password.Text = "Password";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(379, 248);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(135, 29);
            btn_login.TabIndex = 4;
            btn_login.Text = "Iniciar sesion";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // label_login_error
            // 
            label_login_error.AutoSize = true;
            label_login_error.ForeColor = Color.IndianRed;
            label_login_error.Location = new Point(269, 298);
            label_login_error.Name = "label_login_error";
            label_login_error.Size = new Size(250, 20);
            label_login_error.TabIndex = 5;
            label_login_error.Text = "Los datos ingresados no son validos.";
            label_login_error.Visible = false;
            // 
            // form_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_login_error);
            Controls.Add(btn_login);
            Controls.Add(txt_login_password);
            Controls.Add(txt_login_user);
            Controls.Add(label_login);
            Controls.Add(lablel_utn);
            Name = "form_login";
            Text = "UNT - Login";
            Load += form_login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lablel_utn;
        private Label label_login;
        private TextBox txt_login_user;
        private TextBox txt_login_password;
        private Button btn_login;
        private Label label_login_error;
    }
}
