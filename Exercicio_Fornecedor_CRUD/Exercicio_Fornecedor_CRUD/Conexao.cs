//o comando logo abaixo é necessário para conexão com SQL Data instalado
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio_Fornecedor_CRUD
{
    //conexão com o banco de dados 
    class Conexao
    {
        //atributos para conexao com banco
        public MySqlConnection conectar;
        public string servidor;
        public string database;
        public string usuario;
        public string senha;
       

        //método de conexão
        public Conexao()
        {
            inicializar();
        }
        public void inicializar()
        {
            //atributos do banco 
            servidor = "127.0.0.1";
            database = "fornecedor";
            usuario = "root";
            senha = "";
            //variavel com código de conexão com banco
            string conexaostring;
            conexaostring = "SERVER=" + servidor + ";" + "DATABASE=" + database + ";" + "UID=" + usuario + ";" + "PASSWORD=" + senha + ";";
            //conectando
            conectar = new MySqlConnection(conexaostring);
        }

        //método para abrir conexão
        public bool abrirConexao()
        {
            //método try-catch para tentar conexão, e caso dê erro não para a execução
            try
            {
                conectar.Open();
                return true;
            }
            catch(MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        System.Windows.Forms.MessageBox.Show("Não foi possível conectar");
                        break;
                    case 1045:
                        System.Windows.Forms.MessageBox.Show("Usuário e Senha inválidos");
                        break;
                }
                return false;
            }
        }
        //método para fechar conexão
        public bool fecharConexao()
        {
            try
            {
                conectar.Close();
                return true;
            }
            catch(MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
    }

}
