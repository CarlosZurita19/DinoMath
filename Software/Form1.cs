using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexionbd hola = new conexionbd();
            hola.abrir();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_sesion_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-9K9VRTIG\TBD_CAZM;Initial Catalog=Software;Integrated Security=True");
            string query = "Select * from Users Where userName = '" + Txt_usuario.Text.Trim() + "' and userPswr = '" + Txt_contraseña.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Dato.idusuariov = Txt_usuario.Text;
                Menú proyecto = new Menú();
                proyecto.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Revisa los datos ingresados");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro Hola = new Registro();
            Hola.Show();
            this.Hide();

           
        }

        private void Txt_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                btn_sesion_Click(sender, e);
            }
        }

        private void Txt_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Txt_contraseña.Focus();

            }
        }
    }
}
