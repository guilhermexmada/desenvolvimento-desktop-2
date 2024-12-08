using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poo_temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            convert cv = new convert();

            cv.Temperatura = double.Parse(txt_t.Text);

            if (rb_cf.Checked) {
                cv.Tipo_conversao = 0;
            }
            else if (rb_fc.Checked) {
                cv.Tipo_conversao = 1;
            }

            cv.Converte();
            cv.mostraConversao();

            txt_convert.Text = cv.Temperatura_convertida.ToString();
        }
    }
}
