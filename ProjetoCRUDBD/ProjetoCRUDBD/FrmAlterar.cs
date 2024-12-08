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
    public partial class FrmAlterar : Form
    {
        public FrmAlterar()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Empregado emp = new Empregado();
            try
            {
                string cpf;
                cpf = txtCpf.Text;
                emp.Cpf = cpf;
                dgvEmpregadoAlterar.DataSource = emp.ConsultarCpf();
            }
            catch (Exception)
            {

                MessageBox.Show("CPF não encontrado");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Empregado emp = new Empregado();
            string nome, sobrenome, cpf;

            nome = txtNome.Text;
            sobrenome = txtSobrenome.Text;
            cpf = txtCpf.Text;

            //try-catch utilizado para tratamento de erros
            try
            {
                emp.Nome = nome;
                emp.Sobrenome = sobrenome;
                emp.Cpf = cpf;
                emp.Alterar();
                MessageBox.Show("Dados alterados com sucesso!!!");
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao alterar no banco de dados");
            }
        }
    }
}
