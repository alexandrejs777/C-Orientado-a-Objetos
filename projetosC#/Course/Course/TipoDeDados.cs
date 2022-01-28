using System;

namespace Course {
    class TipoDeDados {
        static void Main(string[] args) {

            // Usando apenas variáveis do tipo .Net

            Boolean completo = false;
            Char genero = 'F';
            Char letra = '\u0041';
            SByte n1 = 126;
            Int16 n2 = 1000;
            Int32 n3 = 2147483647;
            Int64 n4 = 2147483648L; // O L no final é uma convenção para indicar que se trata do tipo 'long'
            Single n5 = 4.5f;
            Double n6 = 5.4;
            String nome = "Maria Green";
            Object obj1 = "Alex Brown";
            Object obj2 = 4.5f;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);


            int numMin = int.MinValue;
            int numMax = int.MaxValue;
            decimal num = decimal.MaxValue;

            Console.WriteLine(numMin);
            Console.WriteLine(numMax);
            Console.WriteLine(num);
        }
    }
}
