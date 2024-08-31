using System;
using System.Linq;


// Resposta questão 1//

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Digite um número: "); //entrada//
//         int numero = int.Parse(Console.ReadLine());

//         if (EhFibonacci(numero))
//         {
//             Console.WriteLine($"Este número {numero} pertence à sequência Fibonacci.");
//         }
//         else
//         {
//             Console.WriteLine($"Este número {numero} não pertence à sequência Fibonacci.");
//         }
//     }

//     static bool EhFibonacci(int numero) //verificação//
//     {
//         int n = 0;
//         while (true)
//         {
//             int fib = Fibonacci(n);
//             if (fib == numero)
//                 return true;
//             if (fib > numero)
//                 return false;
//             n++;
//         }
//     }

//     static int Fibonacci(int n)
//     {
//         if (n <= 1)
//             return n;
//         return Fibonacci(n - 1) + Fibonacci(n - 2);
//     }
// }



// Resposta questão 2//

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Digite uma string: ");
//         string input = Console.ReadLine();

//         int count = VerificaLetraA(input);

//         if (count > 0)
//         {
//             Console.WriteLine($"A letra 'a' aparece {count} vez(es) na string.");
//         }
//         else
//         {
//             Console.WriteLine("A letra 'a' não aparece na string.");
//         }
//     }

//     static int VerificaLetraA(string str) //LINQ//
//     {
//         return str.Count(c => c == 'a' || c == 'A');
//     }
// }


// Resposta questão 3//

// int indice = 12;
// int soma = 0;
// int k = 1;

// while (k < indice)
// {
//     k = k + 1;
//     soma = soma + k;
// }

// Console.WriteLine(soma);









