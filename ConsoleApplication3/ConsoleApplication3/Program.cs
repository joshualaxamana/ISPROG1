using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            int iMultiply = int.Parse(Console.ReadLine());

            for (int i = iMultiply; i >= 1; i--)
            {

                Console.WriteLine(i);

            }
            Console.ReadKey();
        }
    }
}
