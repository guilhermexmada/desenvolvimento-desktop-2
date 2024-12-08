using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMedidas
{
    class MetrosparaPes
    {
        private double valor_metros;
        private double valor_pes;
        private double resultado;

        public double Valor_metros
        {
            get
            {
                return valor_metros;
            }

            set
            {
                valor_metros = value;
            }
        }

        public double Valor_pes
        {
            get
            {
                return valor_pes;
            }

            set
            {
                valor_pes = value;
            }
        }

        public double Resultado
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

        //método conversão
        public void Converter()
        {
            valor_pes = valor_metros * 3.281;
            
        }

        public string Mostrar()
        {
            return valor_pes.ToString();
        }
    }
}
