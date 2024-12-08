using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorMedidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void centímetrosPolegadasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void metrosPésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciando classe
            MetrosPes mpp = new MetrosPes();

            mpp.Show();
        }
    }
}
