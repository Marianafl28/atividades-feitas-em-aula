using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class TotalEleitores
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Qual o numero totalde eleitores?");
            int Totais = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Qual o numero total de votos brancos?");
            int Brancos = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Qual o numero total de votos nulos?");
            int Nulos = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Qual o numero total de votos validos?");
            int Validos = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Votos totais " + Totais);

            int TotalBranco = (Brancos * 100) / Totais;
            Console.WriteLine("Total de votos brancos " + TotalBranco + "%");

            int TotalNulo = (Nulos * 100) / Totais;
            Console.WriteLine("Total de votos Nulos " + TotalNulo + "%");

            int TotalValido = (Validos * 100) / Totais;
            Console.WriteLine("Total de votos Validos " + TotalValido + "%");



        }
    }
}
