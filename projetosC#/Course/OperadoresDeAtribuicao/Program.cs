﻿using System;

namespace OperadoresDeAtribuicao {
    class Program {
        static void Main(string[] args) {

            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a -= 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            a /= 2;
            Console.WriteLine(a);

            a %= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            int b = 10;
            b++;
            Console.WriteLine(b);

            b--;
            Console.WriteLine(b);

            int c = a++;
            Console.WriteLine(c);

            c = ++a;
            Console.WriteLine(c);
        }
    }
}
