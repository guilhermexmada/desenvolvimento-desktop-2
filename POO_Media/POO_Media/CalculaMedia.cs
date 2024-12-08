using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Media
{
    class CalculaMedia
    {
        //atributos
        private double nota1;
        private double nota2;
        private double media;
        //encapsulamento
        public double Nota1
        {
            get
            {
                return nota1;
            }

            set
            {
                nota1 = value;
            }
        }

        public double Nota2
        {
            get
            {
                return nota2;
            }

            set
            {
                nota2 = value;
            }
        }

        public double Media
        {
            get
            {
                return media;
            }

            set
            {
                media = value;
            }
        }

        //método
        public void calcularMedia()
        {
            Media = (Nota1 + Nota2) / 2;
        }
    }
}
