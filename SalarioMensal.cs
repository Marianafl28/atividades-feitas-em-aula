using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class SalarioMensal
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Qual o seu salario?");
            int Salario = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Qual a porcentagem do reajuste?");
            int Reajuste = Convert.ToInt16(Console.ReadLine());
            int SalarioFinal = (Salario / 100 * Reajuste) + Salario;
            Console.WriteLine("O salario é :" + SalarioFinal);

        }
    }
}

