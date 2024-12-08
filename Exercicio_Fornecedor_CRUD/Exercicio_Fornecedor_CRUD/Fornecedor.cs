using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Fornecedor_CRUD
{
    // :conexao conecta a classe fornecedor com a classe conexao
    class Fornecedor:Conexao
    {
        //atritutos do fornecedor
        string nome;
        int cnpj;
        int telefone;
        string email;

        //encapsulamento dos atributos do fornecedor
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

        public int Cnpj
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

        public int Telefone
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

        //=====================//

        //método cadastrar (comando insert)
        public void Inserir() {
            //variável com comando SQL insert
            string query = "INSERT INTO fornecedores(nome,cnpj,telefone,email) VALUES ('" + this.nome + "' , '" + this.cnpj + "' , '" + this.telefone + "' , '" + this.email + "')";

            //verifica se método abrirconexão funcionou
            if(this.abrirConexao() == true)
            {
                //executa consulta
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }

        //método consultar (comando select)
        public DataTable Consultar()
        {
            //abre conexão
            this.abrirConexao();
            //variável com comando SQL select
            string query = "SELECT * FROM fornecedores WHERE nome = '" + nome + "'";

            //executa consulta
            MySqlCommand cmd = new MySqlCommand(query, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.fecharConexao();

            //extrai informações do banco
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
