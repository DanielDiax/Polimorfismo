using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Circulo : Figura 
    {
        double radio = 0;

        public double Radio { get => radio; set => radio = value; }

        public Circulo() { }


        public Circulo(double _radio)
        {
            radio = _radio;
        }

        public override double Area()
        {
            double area = 0;

            area = Math.PI * (Math.Pow(radio, 2));

            return area;
        }

        public override double Perimetro()
        {
            double perimetro = 0;

            perimetro = 2 * (Math.PI) * Radio;

            return perimetro;
        }
    }
}
