using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calculaMedia_Click(object sender, EventArgs e)
        {
            //instanciar objeto
            CalculaMedia calc = new CalculaMedia();

            double n1, n2;
            n1 = double.Parse(txt_n1.Text);
            n2 = double.Parse(txt_n2.Text);

            calc.Nota1 = n1;
            calc.Nota2 = n2;

            calc.calcularMedia();
            txt_resultado.Text = calc.Media.ToString();
        }
    }
}
