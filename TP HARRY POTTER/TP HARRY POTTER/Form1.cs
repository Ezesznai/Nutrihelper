using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_HARRY_POTTER
{
    public partial class Form1 : Form
    {
        public char Eq1;
        public char Eq2;
        public int Puntaje1;
        public int Puntaje2 = 0;
        public int PGG;
        public int PGH;
        public int PGR;
        public int PGS;
        public bool Snitch1 = false;
        public bool Snitch2 = false;
        public char[] Equipos;
        public string GanadorP;
        public string GanadorT;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Equipos = new char[4];
            Equipos[0] = 'G';
            Equipos[1] = 'H';
            Equipos[2] = 'R';
            Equipos[3] = 'S';
        }
        public void EqGanador(char[] Equipos, char Eq, int PGG, int PGH, int PGR, int PGS)
        {

            for (int i = 0; i < 4; i++)
            {
                if (Equipos[i] == 'G' && Eq == Equipos[i])
                {
                    MessageBox.Show("El ganador del partido es Griffindor");
                    PGG = +1;
                }
                else if (Equipos[i] == 'H' && Eq == Equipos[i])
                {
                    MessageBox.Show("El ganador del partido es Hufflepuff");
                    PGH = +1;
                }
                else if (Equipos[i] == 'R' && Eq == Equipos[i])
                {
                    MessageBox.Show("El ganador del partido es Ravenclaw");
                    PGR = +1;
                }
                else if (Equipos[i] == 'S' && Eq == Equipos[i])
                {
                    MessageBox.Show("El ganador del partido es Slytherin");
                    PGS = +1;
                }


            }

        }

        private void BtnSnitch1_Click(object sender, EventArgs e)
        {
            Puntaje1 += 150;
            Snitch1 = true;
            if (Puntaje1 > Puntaje2)
            {
                EqGanador(Equipos, Eq1, PGG, PGH, PGR, PGS);
            }
        }

        private void BtnSnitch2_Click(object sender, EventArgs e)
        {
            Puntaje2 += 150;
            if (Puntaje2 > Puntaje1)
            {
                EqGanador(Equipos, Eq2, PGG, PGH, PGR, PGS);
            }
        }

        private void TxtEq1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Eq1 = Convert.ToChar(txtEq1.Text);
            }
            catch
            {

            }
        }

        private void TxtEq2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Eq2 = Convert.ToChar(txtEq2.Text);
            }
            catch
            {

            }
        }

        private void BtnAnotacion1_Click(object sender, EventArgs e)
        {
            Puntaje1 += 10;
            lblPuntaje1.Text = Convert.ToString(Puntaje1);
        }

        private void BtnAnotacion2_Click(object sender, EventArgs e)
        {
            Puntaje1 += 10;
            lblPuntaje2.Text = Convert.ToString(Puntaje2);

        }

        private void BtnFinTorneo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
