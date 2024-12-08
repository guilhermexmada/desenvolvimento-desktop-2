using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoOOExemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_CalcularIdade_Click(object sender, EventArgs e)
        {
            //instanciar objeto
            CalculoIdade calc = new CalculoIdade();

            int idade1, idade2;
            //passa valor da textbox para variáveis 
            idade1 = int.Parse(txt_idade1.Text);
            idade2 = int.Parse(txt_idade2.Text);

            if (rdb_somar.Checked)
            {
                calc.Operacao = "Somar";
            }
            else if (rdb_subtrair.Checked)
            {
                calc.Operacao = "Subtrair";
            }

            //passando valores das variáveis para a classe
            calc.Idade1 = idade1;
            calc.Idade2 = idade2;

            //chama o método da classe
            calc.calcularIdade();
            //mostra valor do atributo na caixa de texto
            //ToString converte para string
            txt_resultado.Text = calc.Resultado.ToString();
        }
            
    }
}
