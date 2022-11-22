using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_HARRY_POTTER_BENJAMIN_MENGOCHEA
{
    public partial class Form1 : Form
    {
        public char Eq1;
        public char Eq2;
        public int Puntaje1;
        public int Puntaje2;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Puntaje2 += 10;
        }

        private void txtEq1_TextChanged(object sender, EventArgs e)
        {
            Eq1 = Convert.ToChar(txtEq1.Text);
        }

        private void txtEq2_TextChanged(object sender, EventArgs e)
        {
            Eq2 = Convert.ToChar(txtEq2.Text);
        }

        private void btnAnotacion1_Click(object sender, EventArgs e)
        {
            Puntaje1 += 10;
        }

        private void btnSnitch1_Click(object sender, EventArgs e)
        {
            Puntaje1 += 150;
            Snitch1 = true;
            if (Puntaje1 > Puntaje2)
            {
                Main(Equipos, Eq1, PGG, PGH, PGR, PGS);
            }
            

        }

        private void btnSnitch2_Click(object sender, EventArgs e)
        {
            Puntaje2 += 150;
            if (Puntaje2 > Puntaje1)
            {
                Main(Equipos, Eq2, PGG, PGH, PGR, PGS);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            char[] Equipos = new char[4];
            Equipos[0] = 'G';
            Equipos[1] = 'H';
            Equipos[2] = 'R';
            Equipos[3] = 'S';
        }
        public static void Main(char[] Equipos, char Eq, int PGG, int PGH, int PGR, int PGS)
        {
            for (int i = 0;i>3; i++){ 
            
            if (Equipos[i] == 'G' && Eq == Equipos[i])
                {
                    MessageBox.Show("El ganador del partido es Griffindor");
                    PGG =+ 1;
                }
            else if (Equipos[i] == 'H' && Eq == Equipos[i])
                {
                    MessageBox.Show("El ganador del partido es Hufflepuff");
                    PGH =+ 1;
                }
            else if (Equipos[i] == 'R' && Eq == Equipos[i])
                {
                    MessageBox.Show("El ganador del partido es Ravenclaw");
                    PGR =+ 1;
                }
            else if (Equipos[i] == 'S' && Eq == Equipos[i])
                {
                    MessageBox.Show("El ganador del partido es Slytherin");
                    PGS =+ 1;
                }


            }




        }


    }

    
}

