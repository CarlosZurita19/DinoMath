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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Inicio = new Form1();
            Inicio.Show();
            this.Close();
        }

        private void btn_sesion_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-9K9VRTIG\TBD_CAZM;Initial Catalog=Software;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Insert into Users values(@txt_nombre,@txt_apellido,@Txt_usuario,@Txt_contraseña) ", con);
            
            cmd.Parameters.AddWithValue("@txt_nombre", txt_nombre.Text);
            cmd.Parameters.AddWithValue("@txt_apellido", txt_apellido.Text);
            cmd.Parameters.AddWithValue("@Txt_usuario", Txt_usuario.Text);
            cmd.Parameters.AddWithValue("@Txt_contraseña", Txt_contraseña.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registro exitoso");

            Form1 inicio = new Form1();
            inicio.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
