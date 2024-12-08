using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Salario
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Salario sal = new Salario();

            double salario = double.Parse(txt_salario.Text);
            string nome = txt_nome.Text;
            int item_Selecionado = cmb_categoria.SelectedIndex;

            if(item_Selecionado == 0)
            {
                sal.Categoria = "A";
            }
            else if(item_Selecionado == 1)
            {
                sal.Categoria = "B";
            }
            else if(item_Selecionado == 2)
            {
                sal.Categoria = "C";
            }
            else
            {
                MessageBox.Show("Selecione uma categoria");
            } 

            sal.Nome = nome;
            sal.Salario_atual = salario;
            sal.calcular_Aumento();

            txt_novosalario.Text = sal.mostrar_Dados();
        }
    }
}
