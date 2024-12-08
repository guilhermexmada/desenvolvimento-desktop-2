using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCRUDBD
{
    class Empregado:Conexao
    {
        private string nome;
        private string sobrenome;
        private string cpf;

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

        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }

            set
            {
                sobrenome = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        //-------------------------//

        public void Inserir()
        {
            string query = "INSERT INTO empregados(nomeEmpregado,sobrenomeEmpregado,cpfEmpregado) VALUES ('" +
                this.nome + "' , '" + this.sobrenome + "' , '" + this.cpf + "')";
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
            string mSQL = "SELECT * FROM empregados";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ConsultarCpf()
        {
            this.abrirConexao();
            string mSQL = "SELECT * FROM empregados WHERE cpfEmpregado = '"+Cpf+"'";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void Alterar()
        {
            string query = "UPDATE empregados set nomeEmpregado = '" + this.nome +
              "', sobrenomeEmpregado = '" + this.sobrenome + "'  where cpfEmpregado= '" + this.cpf + "'";
            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }

        public void Excluir()
        {
            string query = "DELETE FROM empregados WHERE cpfEmpregado = '" + cpf + "'";
            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }
    }
}
