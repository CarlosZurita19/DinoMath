using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Software
{
    class conexionbd
    {
        public string cadena = "Data Source=LAPTOP-9K9VRTIG\\TBD_CAZM;Initial Catalog=Software;Integrated Security=True";

        public SqlConnection Conectarbd = new SqlConnection();

        //Constructor
        public conexionbd()
        {
            Conectarbd.ConnectionString = cadena;
        }

        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                Conectarbd.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRORRRRR " + ex.Message);
            }
        }

        //Metodo para cerrar la conexion
        public void cerrar()
        {
            Conectarbd.Close();
        }
    }
}
