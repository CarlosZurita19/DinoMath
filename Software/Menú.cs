using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace Software
{
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = global::Software.Properties.Resources._22221;
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
          

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Memorama hola = new Memorama();
            hola.Show();
            this.Hide();
        }

        private void Menú_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Operaciones letrero = new Operaciones();
            letrero.Show();
            this.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmPuzzleGame hola = new frmPuzzleGame();
            hola.Show();
            this.Hide();

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = global::Software.Properties.Resources.logotote;
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = global::Software.Properties.Resources.Memorama;
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btn_clasificaciones_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
