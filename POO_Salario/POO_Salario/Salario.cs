using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Salario
{
    class Salario
    {
        private string categoria;
        private string nome;
        private double salario_atual;
        private double novo_Salario;

        public string Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }

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

        public double Salario_atual
        {
            get
            {
                return salario_atual;
            }

            set
            {
                salario_atual = value;
            }
        }

        public double Novo_Salario
        {
            get
            {
                return novo_Salario;
            }

            set
            {
                novo_Salario = value;
            }
        }
        public void calcular_Aumento()
        {
            if(categoria == "A")
            {
                novo_Salario = (salario_atual * 5) / 100 + salario_atual;
            }
            else if(categoria == "B")
            {
                novo_Salario = (salario_atual * 10) / 100 + salario_atual;
            }
            else if(categoria == "C")
            {
                novo_Salario = (salario_atual * 15) / 100 + salario_atual;
            }
        }
        public string mostrar_Dados()
        {
            return "O funcionário " + Nome + " teve aumento de " + novo_Salario;
        }
    }
}
