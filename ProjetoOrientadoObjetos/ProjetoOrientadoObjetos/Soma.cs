using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrientadoObjetos
{
    class Soma
    {
        //atributos da classe Soma
        private int numero1;
        private int numero2;
        private int resultado;

        public int Numero1
        {
            get
            {
                return numero1;
            }

            set
            {
                numero1 = value;
            }
        }

        public int Numero2
        {
            get
            {
                return numero2;
            }

            set
            {
                numero2 = value;
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

        //método somar
        public void Somar()
        {
            resultado = numero1 + numero2;
        }
    }
}
