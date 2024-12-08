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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
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
                emp.Inserir();
                MessageBox.Show("Dados gravados com sucesso!!!");
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao gravar no banco de dados");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultar consultar = new FrmConsultar();
            consultar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAlterar alterar = new FrmAlterar();
            alterar.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
