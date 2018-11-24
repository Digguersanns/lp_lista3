using System;

namespace lp_lista3
{
    class Program
    {
        static void Main(string[] args)
        {
             /* escreva um programa que armazene o valor 999 na variavel A e o valor 
             555 na variavel B. A seguir troque os seus conteudos fazendo com que o 
             valor que estaem A passe para B e vice e versa utilizando uma variavel C 
             para realizar a troca. */

            int A = 999;
            int B = 555;
            int C = 0;
            Console.WriteLine("Exercicio 1");
            Console.WriteLine("--------");
            Console.WriteLine("A==>" + A );
            Console.WriteLine("B==>" + B );
            Console.WriteLine("C==>" + C );
            Console.WriteLine("== TROCA ==");
            C = A;
            A = B;
            B = C;
            Console.WriteLine("A==>" + A );
            Console.WriteLine("B==>" + B );
            Console.WriteLine("C==>" + C );
        }
    }
}
