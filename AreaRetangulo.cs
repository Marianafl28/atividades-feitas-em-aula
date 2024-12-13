using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class AreaRetangulo
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Digite a altura do retangulo");
            int numero1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite a base do retangulo");
            int numero2 = Convert.ToInt16(Console.ReadLine());
            int resultado = numero1 * numero2;
            Console.WriteLine("A area do retangulo é : " + resultado);
        }
    }
}
