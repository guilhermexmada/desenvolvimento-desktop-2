using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_Fornecedores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultar consultar = new FrmConsultar();
            consultar.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            
            string nome = txtNome.Text;
            string cnpj = mskCnpj.Text;
            string telefone = mskTelefone.Text;
            string email = txtEmail.Text;

            

            if ((txtNome.Text == "") && (txtEmail.Text == "") && (mskCnpj.Text == "") && (telefone == ""))
            {

                MessageBox.Show("Preencha todos os campos");

            }
            else
            {
                try
                {
                    fornecedor.Nome = nome;
                    fornecedor.Cnpj = cnpj;
                    fornecedor.Telefone = telefone;
                    fornecedor.Email = email;
                    fornecedor.Inserir();

                    txtNome.Clear();
                    txtEmail.Clear();
                    mskCnpj.Clear();
                    mskTelefone.Clear();

                    MessageBox.Show("Dados gravados com sucesso");

                }
                catch (Exception)
                {

                    MessageBox.Show("Erro ao gravar dados");

                }
            }
        }
    }
}
