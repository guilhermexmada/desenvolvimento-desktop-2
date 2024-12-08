using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMenuWhile
{
    class Tabuada
    {
        private int numero;
        private int numeroTabuada;
        private int tabuadaConv;

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public int NumeroTabuada
        {
            get
            {
                return numeroTabuada;
            }

            set
            {
                numeroTabuada = value;
            }
        }

        public int TabuadaConv
        {
            get
            {
                return tabuadaConv;
            }

            set
            {
                tabuadaConv = value;
            }
        }

        //métodos
        public void calcularTabuada()
        {
            tabuadaConv = numero * numeroTabuada;
        }

        public int mostrarTabuada()
        {
            return tabuadaConv;
        }
    }
}
