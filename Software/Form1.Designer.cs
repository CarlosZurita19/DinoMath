
namespace Software
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_InicioSesion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_sesion = new System.Windows.Forms.Button();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.Txt_contraseña = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PB_contraseña = new System.Windows.Forms.PictureBox();
            this.PB_usuario = new System.Windows.Forms.PictureBox();
            this.PB_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_contraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_InicioSesion
            // 
            this.lbl_InicioSesion.AutoSize = true;
            this.lbl_InicioSesion.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InicioSesion.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_InicioSesion.Location = new System.Drawing.Point(79, 111);
            this.lbl_InicioSesion.Name = "lbl_InicioSesion";
            this.lbl_InicioSesion.Size = new System.Drawing.Size(121, 23);
            this.lbl_InicioSesion.TabIndex = 1;
            this.lbl_InicioSesion.Text = "INICIAR SESIÓN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(13, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 3;
            // 
            // btn_sesion
            // 
            this.btn_sesion.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sesion.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sesion.ForeColor = System.Drawing.Color.White;
            this.btn_sesion.Location = new System.Drawing.Point(14, 246);
            this.btn_sesion.Name = "btn_sesion";
            this.btn_sesion.Size = new System.Drawing.Size(236, 34);
            this.btn_sesion.TabIndex = 4;
            this.btn_sesion.Text = "INICIAR SESIÓN";
            this.btn_sesion.UseVisualStyleBackColor = false;
            this.btn_sesion.Click += new System.EventHandler(this.btn_sesion_Click);
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_usuario.ForeColor = System.Drawing.Color.DarkGreen;
            this.Txt_usuario.Location = new System.Drawing.Point(45, 150);
            this.Txt_usuario.Multiline = true;
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(203, 24);
            this.Txt_usuario.TabIndex = 6;
            this.Txt_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_usuario_KeyDown);
            // 
            // Txt_contraseña
            // 
            this.Txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_contraseña.ForeColor = System.Drawing.Color.DarkGreen;
            this.Txt_contraseña.Location = new System.Drawing.Point(46, 198);
            this.Txt_contraseña.Multiline = true;
            this.Txt_contraseña.Name = "Txt_contraseña";
            this.Txt_contraseña.PasswordChar = '*';
            this.Txt_contraseña.Size = new System.Drawing.Size(203, 24);
            this.Txt_contraseña.TabIndex = 6;
            this.Txt_contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_contraseña_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(93, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "REGISTRO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(108, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "SALIR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PB_contraseña
            // 
            this.PB_contraseña.Image = global::Software.Properties.Resources.png_transparent_computer_icons_skype_icon_design_change_password_logo_internet_share_icon;
            this.PB_contraseña.Location = new System.Drawing.Point(12, 192);
            this.PB_contraseña.Name = "PB_contraseña";
            this.PB_contraseña.Size = new System.Drawing.Size(27, 26);
            this.PB_contraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_contraseña.TabIndex = 2;
            this.PB_contraseña.TabStop = false;
            // 
            // PB_usuario
            // 
            this.PB_usuario.Image = global::Software.Properties.Resources.png_clipart_computer_icons_button_login_image_file_formats_logo;
            this.PB_usuario.Location = new System.Drawing.Point(12, 144);
            this.PB_usuario.Name = "PB_usuario";
            this.PB_usuario.Size = new System.Drawing.Size(27, 26);
            this.PB_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_usuario.TabIndex = 2;
            this.PB_usuario.TabStop = false;
            // 
            // PB_logo
            // 
            this.PB_logo.Image = global::Software.Properties.Resources.LOGO1;
            this.PB_logo.Location = new System.Drawing.Point(83, 12);
            this.PB_logo.Name = "PB_logo";
            this.PB_logo.Size = new System.Drawing.Size(108, 96);
            this.PB_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_logo.TabIndex = 0;
            this.PB_logo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(263, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_contraseña);
            this.Controls.Add(this.Txt_usuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_sesion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PB_contraseña);
            this.Controls.Add(this.PB_usuario);
            this.Controls.Add(this.lbl_InicioSesion);
            this.Controls.Add(this.PB_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_contraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_logo;
        private System.Windows.Forms.Label lbl_InicioSesion;
        private System.Windows.Forms.PictureBox PB_usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PB_contraseña;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_sesion;
        private System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.TextBox Txt_contraseña;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

