using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_operacoes
{
    class matematica
    {
        //atributos + encapsulamento
        private int valor1;
        private int valor2;
        private int resultado;

        public int Valor1
        {
            get
            {
                return valor1;
            }

            set
            {
                valor1 = value;
            }
        }

        public int Valor2
        {
            get
            {
                return valor2;
            }

            set
            {
                valor2 = value;
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

        //métodos
        public void soma() {
            Resultado = Valor1 + Valor2;
        }
        public void subtracao()
        {
            Resultado = Valor1 - Valor2;
        }
        public void multiplicacao()
        {
            Resultado = Valor1 * Valor2;
        }
        public void divisao()
        {
            Resultado = Valor1 / Valor2;
        }
        public string mostrar()
        {
            return "O resultado é " + Resultado;
        }
    }
}
