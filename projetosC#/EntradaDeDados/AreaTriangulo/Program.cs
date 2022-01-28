using System;
using System.Globalization;

namespace AreaTriangulo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            double b, a;

            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            static double Area(double baseT, double altT) {
                double resultado = baseT * altT;
                return resultado;
            }

            static double Perimetro(double baseT, double altT) {
                double resultado = 2 * (baseT + altT);
                return resultado;
            }

            static double Diagonal(double baseT, double altT) {
                double resultado = Math.Sqrt(Math.Pow(baseT, 2.0) + Math.Pow(altT, 2.0));
                return resultado;
            }

            Console.WriteLine("AREA = " + Area(b, a).ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + Perimetro(b, a).ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + Diagonal(b, a).ToString("f4", CultureInfo.InvariantCulture));
        }
    }
}
