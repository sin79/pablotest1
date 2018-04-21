using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)

        {
            int a, i, j, x, y, z;
            string gwiazdka, puste;
            Console.WriteLine("Podaj wysokosc choinki: ");
            n = int.Parse(Console.ReadLine());
            gwiazdka = "*";
            puste = " ";
            a = x;
            for (i = 1; i <= x; i++)
            {
                for (j = 1; j < a; j++)
                {
                    Console.Write(nic);
                }
                for (y = 1; y <= i; y++)
                {
                    Console.Write(gwiazdka);
                }
                for (z = 1; z <= i - 1; z++)
                {
                    Console.Write(gwiazdka);
                }
                a--;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
