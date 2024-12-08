using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Fornecedor_CRUD
{
    public partial class FRM_Consultar : Form
    {
        public FRM_Consultar()
        {
            InitializeComponent();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            //ao clique
            //executa o método consultar e coloca os dados no datagridview
            Fornecedor fornec = new Fornecedor();
            dgv_listar.DataSource = fornec.Consultar();
        }
    }
}
