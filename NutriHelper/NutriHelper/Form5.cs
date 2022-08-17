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
    public partial class Form5 : Form
    {
        public Form5()
        {
           if (Datos.edad > 0) { 
            InitializeComponent();
        }
           else
            {
                Form1 Pantalla_principal = new Form1();
                Pantalla_principal.Show();
                this.Close();
            }
          
                }

    }
}

    
