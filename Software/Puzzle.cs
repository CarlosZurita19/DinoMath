using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Software
{
    public partial class frmPuzzleGame : Form
    {
        int inNullSliceIndex, inmoves = 0;
        List<Bitmap> lstOriginalPictureList = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        DataClasses1DataContext procedimiento3 = new DataClasses1DataContext();

        public frmPuzzleGame()
        {
            InitializeComponent();
            lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources.a, Properties.Resources.b, Properties.Resources.c, Properties.Resources.d, Properties.Resources.e, Properties.Resources.f, Properties.Resources.g, Properties.Resources.h, Properties.Resources.i, Properties.Resources._null});
            lblMovesMade.Text += inmoves;
            lblTimeElapsed.Text = "00:00:00";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Shuffle();
        }

        void Shuffle()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });//8 is not present - since it is the last slice.
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)gbPuzzleBox.Controls[i]).Image = lstOriginalPictureList[j];
                    if (j == 9) inNullSliceIndex = i;//store empty picture box index
                }
            } while (CheckWin());
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();     
            if (lblTimeElapsed.Text != "00:00:00")
            {
                YesOrNo = MessageBox.Show("Seguro que quieres reiniciar?", "ROMPECABEZAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (YesOrNo == DialogResult.Yes || lblTimeElapsed.Text == "00:00:00")
            {
                Shuffle();
                timer.Reset();
                lblTimeElapsed.Text = "00:00:00";
                inmoves = 0;
                lblMovesMade.Text = "Movimientos :  0";
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNO = MessageBox.Show("Quieres ir a la tabla de rankings ?", "ROMPECABEZAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button != btnQuit && YesOrNO == DialogResult.No)
            {
                Menú hola = new Menú();
                hola.Show();
            }
            if (sender as Button == btnQuit && YesOrNO == DialogResult.Yes)
            {
                Clasificaciones regresar = new Clasificaciones();
                regresar.Show();
                this.Close();
            }
        }

        private void SwitchPictureBox(object sender, EventArgs e)
        {
            if (lblTimeElapsed.Text == "00:00:00")
                timer.Start();
            int inPictureBoxIndex = gbPuzzleBox.Controls.IndexOf(sender as Control);
            if (inNullSliceIndex != inPictureBoxIndex)
            {
                List<int> FourBrothers = new List<int>(new int[] { ((inPictureBoxIndex % 3 == 0) ? -1 : inPictureBoxIndex - 1), inPictureBoxIndex - 3, (inPictureBoxIndex % 3 == 2) ? -1 : inPictureBoxIndex + 1, inPictureBoxIndex + 3 });
                if (FourBrothers.Contains(inNullSliceIndex))
                {
                    ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Image = ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image = lstOriginalPictureList[9];
                    inNullSliceIndex = inPictureBoxIndex;
                    lblMovesMade.Text = "Movimientos : " + (++inmoves);
                    if (CheckWin())
                    { 
                        
                        timer.Stop();
                        (gbPuzzleBox.Controls[8] as PictureBox).Image = lstOriginalPictureList[8];
                        MessageBox.Show("Felicidades...\nLo haz logrado\nTiempo : " + timer.Elapsed.ToString().Remove(8) + "\nMovimientos totales : " + inmoves, "ROMPECABEZAS");
                        conexionbd hola = new conexionbd();
                        hola.abrir();
                        procedimiento3.Puzzle_PointsInsert(Dato.idusuariov, inmoves,Convert.ToString(timer.Elapsed.ToString().Remove(8)));
                        inmoves = 0;
                        lblMovesMade.Text = "Movimientos : 0";
                        lblTimeElapsed.Text = "00:00:00";
                        timer.Reset();
                        Shuffle();



                    }
                }
            }
        }

        bool CheckWin()
        {
            int i;
            for (i = 0; i < 8; i++)
            {
                if ((gbPuzzleBox.Controls[i] as PictureBox).Image != lstOriginalPictureList[i]) break;
            }
            if (i == 8) return true;
            else return false;
        }

        private void UpdateTimeElapsed(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
                lblTimeElapsed.Text = timer.Elapsed.ToString().Remove(8);
            if (timer.Elapsed.ToString() == "00:00:00")
                btnPause.Enabled = false;
            else
                btnPause.Enabled = true;
            if (timer.Elapsed.Minutes.ToString() == "120")
            {
                timer.Reset();
                lblMovesMade.Text = "Movimientos : 0";
                lblTimeElapsed.Text = "00:00:00";
                inmoves = 0;
                btnPause.Enabled = false;
                MessageBox.Show("Se acabo el tiempo\nIntenta de nuevo", "ROMPECABEZAS");
                Shuffle();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void PauseOrResume(object sender, EventArgs e)
        {
            if (btnPause.Text == "Pausar")
            {
                timer.Stop();
                gbPuzzleBox.Visible = false;
                btnPause.Text = "Continuar";
            }
            else
            {
                timer.Start();
                gbPuzzleBox.Visible = true;
                btnPause.Text = "Pausar";
            }
        }
    }
}
