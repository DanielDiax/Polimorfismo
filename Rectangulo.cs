using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Rectangulo: Figura
    {
        double largo = 0;
        double ancho = 0;

        double lado1 = 0;
        double lado2 = 0;
        double lado3 = 0;
        double lado4 = 0;

        public double Largo { get => largo; set => largo = value; }
        public double Ancho { get => ancho; set => ancho = value; }
        public double Lado1 { get => lado1; set => lado1 = value; }
        public double Lado2 { get => lado2; set => lado2 = value; }
        public double Lado3 { get => lado3; set => lado3 = value; }
        public double Lado4 { get => lado4; set => lado4 = value; }

        public Rectangulo() { }


        public Rectangulo(double _largo, double _ancho)
        {
            largo = _largo;
            ancho = _ancho;
        }

        public override double Area()
        {
            return largo * ancho;
        }

        public override double Perimetro()
        {
            return lado1 + lado2 + lado3 + lado4;
        }
    }
}
