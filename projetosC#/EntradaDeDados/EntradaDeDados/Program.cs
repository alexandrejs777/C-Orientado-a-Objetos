using System;
using System.Globalization;

namespace EntradaDeDados {
    class Program {
        static void Main(string[] args) {

            int num = int.Parse(Console.ReadLine());
            char letra = char.Parse(Console.ReadLine());
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


            Console.WriteLine("Você digitou:");
            Console.WriteLine(num);
            Console.WriteLine(letra);
            Console.WriteLine(numero.ToString("f2",CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}
