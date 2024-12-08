using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_temperatura
{
    class convert
    {
        private double temperatura;
        private double temperatura_convertida;
        private int tipo_conversao;

        public double Temperatura
        {
            get
            {
                return temperatura;
            }

            set
            {
                temperatura = value;
            }
        }

        public double Temperatura_convertida
        {
            get
            {
                return temperatura_convertida;
            }

            set
            {
                temperatura_convertida = value;
            }
        }

        public int Tipo_conversao
        {
            get
            {
                return tipo_conversao;
            }

            set
            {
                tipo_conversao = value;
            }
        }

        public void Converte()
        {
            if (tipo_conversao == 0)
            {
                temperatura_convertida = temperatura + 32;
            }
            else if(tipo_conversao == 1)
            {
                temperatura_convertida = temperatura - 32;
            }
        }
        public string mostraConversao()
        {
            return temperatura_convertida.ToString();
        }
    }
}
