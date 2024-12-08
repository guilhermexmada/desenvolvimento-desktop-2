using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOrientadoObjetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //instanciação do objeto
            Soma som = new Soma();
            int num1, num2;
            num1 = int.Parse(txtNumeroUm.Text);
            num2 = int.Parse(txtNumerodois.Text);
            som.Numero1 = num1;
            som.Numero2 = num2;
            som.Somar();
            txtMostraresultado.Text = ("" + som.Resultado);
        }

        private void txtMostraresultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
