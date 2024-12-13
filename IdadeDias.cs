using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class IdadeDias
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Quantos anos você tem?");
            int Anos = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Quantos meses você tem?");
            int Meses = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Quanos dias você tem");
            int Dias = Convert.ToInt16(Console.ReadLine());

            int total = (Anos * 365) + (Meses * 30) + Dias;
            Console.WriteLine("Sua idade em dias é " + total);



        }
    }
}
