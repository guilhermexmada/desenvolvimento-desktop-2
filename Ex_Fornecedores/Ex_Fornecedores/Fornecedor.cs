using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Ex_Fornecedores
{
    class Fornecedor:Conexao
    {
        private string nome;
        private string cnpj;
        private string telefone;
        private string email;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Cnpj
        {
            get
            {
                return cnpj;
            }

            set
            {
                cnpj = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public void Inserir()
        {
            string query = "INSERT INTO fornecedor(nomeFornecedor,cnpjFornecedor,telefoneFornecedor,emailFornecedor) VALUES ('" +
                this.nome + "' , '" + this.cnpj + "' , '" + this.telefone + "' , '" + this.email + "')";
            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }

        public DataTable Consultar()
        {
            this.abrirConexao();
            string mSQL = "SELECT * FROM fornecedor";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
