using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriHelper
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void LblTipoDInfografia_Click(object sender, EventArgs e)
        {
        }

        private void BtnInfo1_Click(object sender, EventArgs e)
        {
            pcbInfo1.BringToFront();
            lblTipoDInfografia.Text = "1"; 
        }

        private void BtnInfo2_Click(object sender, EventArgs e)
        {
            pcbInfo2.BringToFront();
            lblTipoDInfografia.Text = "2";
        }

        private void BtnInfo3_Click(object sender, EventArgs e)
        {
            pcbInfo3.BringToFront();
            lblTipoDInfografia.Text = "3";
        }

        private void BtnInfo4_Click(object sender, EventArgs e)
        {
            pcbInfo4.BringToFront();
            lblTipoDInfografia.Text = "4";
        }

        private void BtnInfo5_Click(object sender, EventArgs e)
        {
            pcbInfo5.BringToFront();
            lblTipoDInfografia.Text = "5";
        }

        private void BtnInfo6_Click(object sender, EventArgs e)
        {
            pcbInfo6.BringToFront();
            lblTipoDInfografia.Text = "6";

        }

        private void BtnInfo7_Click(object sender, EventArgs e)
        {
            pcbInfo7.BringToFront();
            lblTipoDInfografia.Text = "7";
        }

        private void BtnInfo8_Click(object sender, EventArgs e)
        {
            pcbInfo8.BringToFront();
            lblTipoDInfografia.Text = "8";
        }
    }
}
