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
    public partial class Operaciones : Form
    {
        DataClasses1DataContext procedimiento1 = new DataClasses1DataContext();
        Random rnd = new Random();
        string[] Maths = { "Suma", "Resta", "Multiplicación" };
        int total;
        int score;
        public Operaciones()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

            int userEntered = Convert.ToInt32(txtAnswer.Text);
            if (userEntered == total)
            {
                answer.Text = "Correcto";
                answer.ForeColor = Color.DarkGreen;
                score += 1;
                lblMovesMade.Text = "RECORD: " + score; 
                SetUpGame();

            }
            else
            {
                answer.Text = "Incorrecto";
                answer.ForeColor = Color.DarkRed;
            }
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAnswer.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingresa solamente números");
                txtAnswer.Text = txtAnswer.Text.Remove(txtAnswer.Text.Length - 1);
            }
        }
        private void SetUpGame()
        {
            int numA = rnd.Next(10, 20);
            int numB = rnd.Next(0, 9);

            txtAnswer.Text = null;

            switch (Maths[rnd.Next(0, Maths.Length)])
            {
                case "Suma":
                    total = numA + numB;
                    lblSymbol.Text = "+";
                    lblSymbol.ForeColor = Color.MediumAquamarine;
                    break;

                case "Resta":
                    total = numA - numB;
                    lblSymbol.Text = "-";
                    lblSymbol.ForeColor = Color.Orange;
                    break;

                case "Multiplicación":
                    total = numA * numB;
                    lblSymbol.Text = "x";
                    lblSymbol.ForeColor = Color.DarkOrchid;
                    break;
            }
            lblNumA.Text = numA.ToString();
            lblNumB.Text = numB.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNO = MessageBox.Show("Quieres ir a la tabla de rankings?", "OPERACIONES", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button != btnQuit && YesOrNO == DialogResult.No)
            {
                Menú hola = new Menú();
                hola.Show();
            }
            if (sender as Button != btnQuit && YesOrNO == DialogResult.Yes)
            {
                conexionbd hola = new conexionbd();
                hola.abrir();
                procedimiento1.BasicMaths_Insert(Dato.idusuariov, score);
                Clasificaciones regresar = new Clasificaciones();
                regresar.Show();
                this.Close();
            }
        }

        private void Operaciones_Load(object sender, EventArgs e)
        {
        }
    }
}
