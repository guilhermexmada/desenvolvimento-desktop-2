using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMenuWhile
{
    public partial class Frm_Tabuada : Form
    {
        public Frm_Tabuada()
        {
            InitializeComponent();
        }

        private void Frm_Tabuada_Load(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            txt_resultado.Clear();
            //instanciando classe
            Tabuada tabu = new Tabuada();
            //declarando variáveis
            decimal vf = nud_final.Value;
            decimal vi = nud_inicial.Value;
            int tabuada = int.Parse(txt_tabuada.Text);


            while (vi <= vf)
            {
                tabu.Numero = Decimal.ToInt32(vi);
                tabu.NumeroTabuada = tabuada;
                tabu.calcularTabuada();
                txt_resultado.Text += vi + " X " + tabuada + " = " + tabu.mostrarTabuada() + "\r\n";
                vi++;
            }
        }
    }
}
