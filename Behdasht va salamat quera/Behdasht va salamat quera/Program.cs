using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Behdasht_va_salamat_quera
{
    class Program
    {
        static void Main(string[] args)
        {
            double X = double.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            if (N == 0)
            {
                Console.WriteLine(20);
            }
            else if(N==7)
            {
                Console.WriteLine(X);

            }
            else
            {
                if (X - N < 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(X - N);
                }
            }
            Console.ReadLine();
        }
    }
}
