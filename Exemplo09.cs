using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    internal class Exemplo09
    {
        public static void Main(string[] args)
        {
            int x = 1; int y = 3;
            for (int i = 1; i < = 2; i++)
            {
                Console.WriteLine("Item : " + i);

                for (int j = x; j <= y; j++)
                {
                    Console.WriteLine("SubItem" + j);
                }
                x = x + 3;
                y = y + 3;
            }

        }
    }
}
