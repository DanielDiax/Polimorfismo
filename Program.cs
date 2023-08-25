using System;
using System.Collections.Generic;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura[] figuras = new Figura[3];
            
            figuras[0] = new Circulo(3);
            figuras[1] = new Rectangulo(5,3);
            figuras[2] = new Triangulo(8, 4);


            List<Figura> figuras1 = new List<Figura>();

            Triangulo triangulo = new Triangulo();

            triangulo.Lado1 = 5;
            triangulo.Lado2 = 4;
            triangulo.Lado3 = 3;

            figuras1.Add(new Circulo(5));
            figuras1.Add(triangulo);

            foreach (var figura in figuras)
            {
                Console.WriteLine(figura.GetType());
                Console.WriteLine($"{figura.Area()}");
                Console.WriteLine(figura.Perimetro().ToString());
            }

            foreach (var figura in figuras1)
            {
                Console.WriteLine(figura.GetType());
                Console.WriteLine(figura.Area().ToString());
                Console.WriteLine(figura.Perimetro().ToString());
            }
        }
    }
}
