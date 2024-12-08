using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_IMC
{
    class IMC
    {
        private string nome;
        private double peso;
        private double altura;
        private string situacao;
        private double imc;
        private string sexo;

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

        public double Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = value;
            }
        }

        public double Altura
        {
            get
            {
                return altura;
            }

            set
            {
                altura = value;
            }
        }

        public string Situacao
        {
            get
            {
                return situacao;
            }

            set
            {
                situacao = value;
            }
        }

        public double Imc
        {
            get
            {
                return imc;
            }

            set
            {
                imc = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public void calcularIMC()
        {
            imc = peso / (altura * altura);
            

        }

        public string verificarSituacao()
        {
            if (sexo == "M")
            {
                if (imc < 20.7)
                {
                    situacao = "Abaixo do peso";
                }
                else if (imc >= 20.7 && imc <= 26.4)
                {
                    situacao = "Peso ideal";
                }
                else if (imc > 26.4)
                {
                    situacao = "Acima do peso";
                }
            }
            else if (sexo == "F")
            {
                if (imc < 19.1)
                {
                    situacao = "Abaixo do peso";
                }
                else if (imc >= 19.1 && imc <= 25.8)
                {
                    situacao = "Peso ideal";
                }
                else if (imc > 25.8)
                {
                    situacao = "Acima do peso";
                }
            }
            return situacao;

        }
    }
}
