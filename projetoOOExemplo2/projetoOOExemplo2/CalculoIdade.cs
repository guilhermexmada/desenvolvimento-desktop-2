using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoOOExemplo2
{
    class CalculoIdade
    {
        //declaramos atributos
        private int idade1;
        private int idade2;
        private int resultado;
        private string operacao;

        //encapsulamento
        public int Idade1
        {
            get
            {
                return idade1;
            }

            set
            {
                idade1 = value;
            }
        }

        public int Idade2
        {
            get
            {
                return idade2;
            }

            set
            {
                idade2 = value;
            }
        }

        public int Resultado
        {
            get
            {
                return resultado;
            }

            set
            {
                resultado = value;
            }
        }

        public string Operacao
        {
            get
            {
                return operacao;
            }

            set
            {
                operacao = value;
            }
        }

        //método
        public void calcularIdade()
        {
            if(operacao == "Subtrair")
            {
                resultado = idade1 - idade2;
            }
            else if(operacao == "Somar")
            {
                resultado = idade1 + idade2;
            }
        }

        
    }
}
