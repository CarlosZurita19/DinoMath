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
    public partial class Clasificaciones : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-9K9VRTIG\\TBD_CAZM;Initial Catalog=Software;Integrated Security=True");
        public Clasificaciones()
        {

            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Menú Inicio = new Menú();
            Inicio.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                conexion.Open();
            }
            catch(Exception)
            { 

            }
            conexionbd nueva = new conexionbd();
            nueva.abrir();
            SqlCommand comando = new SqlCommand("Select userName as [Usuario], BMPoints as [Puntos] from BasicMaths_Points order by BMPoints DESC", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
            }
            catch (Exception)
            {

            }
            conexionbd nueva = new conexionbd();
            nueva.abrir();
            SqlCommand comando = new SqlCommand("Select userName as [Usuario], MMPoints as [Movimientos] from Memo_Points order by MMPoints ASC", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
            }
            catch (Exception)
            {

            }
            conexionbd nueva = new conexionbd();
            nueva.abrir();
            SqlCommand comando = new SqlCommand("Select userName as [Usuario], PZTime as [Tiempo], PZPoints as [Movimientos] from Puzzle_Points order by PZTime ASC ", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void btn_regresar_Click_1(object sender, EventArgs e)
        {
            Menú hola = new Menú();
            hola.Show();
            this.Close();
        }
    }
}
