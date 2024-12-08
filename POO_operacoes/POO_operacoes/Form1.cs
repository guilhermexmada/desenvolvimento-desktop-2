using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_operacoes
{
    public partial class box : Form
    {
        public box()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            matematica mat = new matematica();

            int valor1 = int.Parse(txtValor1.Text);
            int valor2 = int.Parse(txtValor2.Text);
            mat.Valor1 = valor1;
            mat.Valor2 = valor2;

            if (btnAdd.Checked)
            {
                mat.soma();
                
            }
            else if (btnSub.Checked)
            {
                mat.subtracao();
            }
            else if (btnMult.Checked)
            {
                mat.multiplicacao();
            }
            else if (btnDiv.Checked)
            {
                mat.divisao();
            }
            txtResultado.Text = mat.mostrar();
        }
    }
}
