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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            //mudar da tela inicial para tela de consulta
            FRM_Consultar consultar = new FRM_Consultar();
            this.Hide();
            consultar.Show();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //instanciando classe fornecedor
            Fornecedor fornec = new Fornecedor();

            

            //try-catch que tenta cadastrar e envia mensagem em caso de erro
            try
            {
                //guardando respostas dos inputs diretamente nas variáveis da classe
                fornec.Nome = txt_nome.Text;
                fornec.Cnpj = int.Parse(txt_cnpj.Text);
                fornec.Email = txt_email.Text;
                fornec.Telefone = int.Parse(txt_telefone.Text);
                //executando método cadastrar
                fornec.Inserir();
                MessageBox.Show("Cadastrado !");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao realizar cadastro, tente novamente");
            }
        }
    }
}
