using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCRUDBD
{
    public partial class frmExcluir : Form
    {
        public frmExcluir()
        {
            InitializeComponent();
        }
        Empregado emp = new Empregado();

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
        
            try
            {
                string cpf;
                cpf = txtCpf.Text;

                dgvEmpregadoExcluir.DataSource = emp.ConsultarCpf();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível consultar");
            }
         
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf;
                cpf = txtCpf.Text;
                emp.Excluir();
                MessageBox.Show("Dados excluídos com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível excluir...");
            }
        }
    }
}
