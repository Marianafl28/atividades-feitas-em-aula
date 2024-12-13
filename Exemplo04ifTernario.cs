using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class Exemplo04ifTernario
    {
        public static void Main(string[] args)

        {
            Console.WriteLine("Digite um numero ");
            int numero = Convert.ToInt16(Console.ReadLine());
            string mensagem = (numero < 10) ? " Numero menor que 10" : "Numero maior que 10";
            Console.WriteLine(mensagem);
        }
    }
}
