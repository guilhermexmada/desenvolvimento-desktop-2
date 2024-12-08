using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_calculo_Click(object sender, EventArgs e)
        {
            IMC imc = new IMC();

            double peso = double.Parse(txt_peso.Text);
            double altura = double.Parse(txt_altura.Text);
            int sexo = cmb_sexo.SelectedIndex;

            if(sexo == 0)
            {
                imc.Sexo = "M";
            }
            else if(sexo == 1)
            {
                imc.Sexo = "F";
            }

            imc.Peso = peso;
            imc.Altura = altura;
            imc.calcularIMC();
            imc.verificarSituacao();

            lb_imc.Text = imc.Imc.ToString();
            lb_situacao.Text = imc.Situacao;
        }

    }
}
