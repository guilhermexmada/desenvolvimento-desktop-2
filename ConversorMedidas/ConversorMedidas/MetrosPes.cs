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
    public partial class MetrosPes : Form
    {
        public MetrosPes()
        {
            InitializeComponent();
        }

        private void MetrosPes_Load(object sender, EventArgs e)
        {

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            //instanciando classe
            MetrosparaPes mpp = new MetrosparaPes();

            //declarando e guardando nas 
       
                mpp.Valor_metros = double.Parse(txt_metros.Text);
            

            //chamando método de converter
            mpp.Converter();
            //chamando método de exibição
            mpp.Mostrar();

            //mostrando o retorno do Mostrar() na caixa de texto
            txt_pes.Text = mpp.Valor_pes.ToString();
        }
    }
}
