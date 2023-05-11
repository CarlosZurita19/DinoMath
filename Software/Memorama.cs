using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software
{
    public partial class Memorama : Form
    {
        int TamañoColumnasFilas = 4;
        int Movimientos = 0;
        int CantidadDeCartasVolteadas = 0;
        List<string> CartasEnumeradas;
        List<string> CartasRevueltas;
        ArrayList CartasSeleccionadas;
        PictureBox CartaTemporal1;
        PictureBox CartaTemporar2;
        int CartaActual = 0;
        DataClasses1DataContext procedimiento2 = new DataClasses1DataContext();

        public Memorama()
        {
            InitializeComponent();
            iniciarJuego();
        }
        public void iniciarJuego()
        {
            timer1.Enabled = false;
            timer1.Stop();
            lbl_numero.Text = "0";
            CantidadDeCartasVolteadas = 0;
            Movimientos = 0;
            panel1.Controls.Clear();
            CartasEnumeradas = new List<string>();
            CartasRevueltas = new List<string>();
            CartasSeleccionadas = new ArrayList();
            for (int i = 0; i < 8; i++)
            {
                CartasEnumeradas.Add(i.ToString());
                CartasEnumeradas.Add(i.ToString());
            }
            var NumeroAleatorio = new Random();
            var Resultado = CartasEnumeradas.OrderBy(item => NumeroAleatorio.Next());
            foreach (string ValorCarta in Resultado)
            {
                CartasRevueltas.Add(ValorCarta);
            }
            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = TamañoColumnasFilas;
            tablaPanel.ColumnCount = TamañoColumnasFilas;
            for (int i = 0; i < TamañoColumnasFilas; i++)
            {
                var Porcentaje = 150f / (float)TamañoColumnasFilas - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }
            int contadorFichas = 1;

            for (var i = 0; i < TamañoColumnasFilas; i++)
            {
                for (var j = 0; j < TamañoColumnasFilas; j++)
                {
                    var CartasJuego = new PictureBox();
                    CartasJuego.Name = string.Format("{0}", contadorFichas);
                    CartasJuego.Dock = DockStyle.Fill;
                    CartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJuego.Image = Properties.Resources.LOGO1;
                    CartasJuego.Cursor = Cursors.Hand;
                    CartasJuego.Click += Btn_carta_Click;
                    tablaPanel.Controls.Add(CartasJuego, j, i);
                    contadorFichas++;
                }
            }
            tablaPanel.Dock = DockStyle.Fill;
            panel1.Controls.Add(tablaPanel);

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    CartasEnumeradas.Add(i.ToString());
                    CartasEnumeradas.Add(j.ToString());
                }


            }

        }
        private void Btn_reinicio_Click(object sender, EventArgs e)
        {
            iniciarJuego();
        }

        private void Btn_carta_Click(object sender, EventArgs e)
        {
            if (CartasSeleccionadas.Count < 2)
            {
                Movimientos++;
                lbl_numero.Text = Convert.ToString(Movimientos);
                var CartasSeleccionadasUsuario = (PictureBox)sender;

                CartaActual = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartasSeleccionadasUsuario.Name) - 1]);
                CartasSeleccionadasUsuario.Image = RecuperarImagen(CartaActual);
                CartasSeleccionadas.Add(CartasSeleccionadasUsuario);
                //  2 Veces se realizo el evento del click
                if (CartasSeleccionadas.Count == 2)
                {
                    CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                    CartaTemporar2 = (PictureBox)CartasSeleccionadas[1];
                    int Carta1 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal1.Name) - 1]);
                    int Carta2 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporar2.Name) - 1]);

                    if (Carta1 != Carta2)
                    {
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        CantidadDeCartasVolteadas++;
                        if (CantidadDeCartasVolteadas > 7)
                        {
                            conexionbd hola = new conexionbd();
                            hola.abrir();
                            procedimiento2.Memo_PointsInsert(Dato.idusuariov, Convert.ToInt32(lbl_numero.Text));
                            Dato.movimientos = lbl_numero.Text;

                            MessageBox.Show("Felicidades el juego ha terminado");

                        }
                        CartaTemporal1.Enabled = false; CartaTemporar2.Enabled = false;
                        CartasSeleccionadas.Clear();
                    }
                }
            }
        }
        public Bitmap RecuperarImagen(int NumeroImagen)
        {
            Bitmap TmpImg = new Bitmap(200, 100);
            switch (NumeroImagen)
            {
                case 0:
                    TmpImg = Properties.Resources.hueso1;
                    break;
                default:
                    TmpImg = (Bitmap)Properties.Resources.ResourceManager.GetObject("_" + NumeroImagen);
                    break;
            }
            return TmpImg;
        }
        private void Memorama_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;
            if (TiempoVirarCarta == 1)
            {
                CartaTemporal1.Image = Properties.Resources.LOGO1;
                CartaTemporar2.Image = Properties.Resources.LOGO1;
                CartasSeleccionadas.Clear();
                TiempoVirarCarta = 0;
                timer1.Stop();
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNO = MessageBox.Show("Quieres ir a la tabla de rankings?", "OPERACIONES", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button != Btn_reinicio && YesOrNO == DialogResult.No)
            {
                Menú hola = new Menú();
                hola.Show();
            }
            if (sender as Button != Btn_reinicio && YesOrNO == DialogResult.Yes)
            {
                Clasificaciones regresar = new Clasificaciones();
                regresar.Show();
                this.Close();

            }
        }
    }
}

