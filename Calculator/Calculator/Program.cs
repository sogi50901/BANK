using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a And b :" );
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter one of four main action: ");
            Char c = (char)Console.Read();
            if (c is '*')
            {
                Console.WriteLine(a * b);
            }
            else if (c is '-')
            {
                Console.WriteLine(a - b);
            }
            else if (c is '+')
            {
                Console.WriteLine(a + b);

            }
            else if(b!=0)
            {
                Console.WriteLine(a / b);
            }
            else
            {
                Console.WriteLine("error");
            }Console.ReadLine();
            Console.ReadLine();
        } 
    }
}
