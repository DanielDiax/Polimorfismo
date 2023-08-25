namespace Polimorfismo
{
    public class Triangulo : Figura
    {
        double baseTriangulo = 0;
        double altura = 0;

        double lado1 = 0;
        double lado2 = 0;
        double lado3 = 0;

        public double BaseTriangulo { get => baseTriangulo; set => baseTriangulo = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Lado1 { get => lado1; set => lado1 = value; }
        public double Lado2 { get => lado2; set => lado2 = value; }
        public double Lado3 { get => lado3; set => lado3 = value; }

        public Triangulo() { }


        public Triangulo(double _baseTriengulo, double _altura)
        {
            baseTriangulo = _baseTriengulo;
            altura = _altura;
        }


        public override double Area()
        {
            double area = 0;

            area = (baseTriangulo * altura) / 2;

            return area;
        }

        public override double Perimetro()
        {
            double perimetro = 0;

            perimetro = lado1 + lado2 + lado3;

            return perimetro;
        }
    }
}
