using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class Sucessor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            int numero1 = Convert.ToInt16(Console.ReadLine());

            int resultado = numero1 + 1;
            Console.WriteLine("O sucessor do número é: " + resultado);
        }
    }
}
