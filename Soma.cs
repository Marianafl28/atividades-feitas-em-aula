using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class Soma
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Digite um número: ");
            int numero1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int numero2 = Convert.ToInt16(Console.ReadLine());
            int resultado = numero1 + numero2;
            Console.WriteLine("O resultado da soma é: " + resultado);
        }
    }
}

