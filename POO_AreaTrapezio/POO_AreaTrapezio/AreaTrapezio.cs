using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_AreaTrapezio
{
    class AreaTrapezio
    {
        private double basemenor, basemaior, altura, area;

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

        public double Area
        {
            get
            {
                return area;
            }

            set
            {
                area = value;
            }
        }

        public double Basemaior
        {
            get
            {
                return basemaior;
            }

            set
            {
                basemaior = value;
            }
        }

        public double Basemenor
        {
            get
            {
                return basemenor;
            }

            set
            {
                basemenor = value;
            }
        }
        public void CalculaArea()
        {
            area = ((basemenor + basemaior) * altura) / 2;
        }
        public string MostrarArea()
        {
            return "Área: " + area;
        }
    }
}
