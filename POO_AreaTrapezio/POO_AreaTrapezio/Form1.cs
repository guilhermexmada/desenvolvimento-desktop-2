using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_AreaTrapezio
{
    public partial class Trapézio : Form
    {
        public Trapézio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_resposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_calculo_Click(object sender, EventArgs e)
        {
            //instanciando classe
            AreaTrapezio atra = new AreaTrapezio();
            //declarando variáveis e jogando na classe
            atra.Basemaior = double.Parse(txt_bmaior.Text);
            atra.Basemenor = double.Parse(txt_bmenor.Text);
            atra.Altura = double.Parse(txt_altura.Text);
            //chamando método de álculo
            atra.CalculaArea();
            //chamando método de exibição
            atra.MostrarArea();
            //jogando o return do método de exibição na caixa de resposta
            txt_resposta.Text = atra.Area.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_bmenor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_bmaior_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_altura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
