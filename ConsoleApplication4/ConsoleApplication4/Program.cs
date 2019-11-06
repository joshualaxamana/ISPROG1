using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My First Loops - Abram John Limpin";

            Console.Write("Input number: ");
            int iMultiply = int.Parse(Console.ReadLine());
            int x = 1; 
            for (int i = 0; i <= iMultiply; i++)
            {
                
                Console.WriteLine(x);
                x = x * 2;
                
                
            }
            Console.ReadKey();
        }
        
    }
}
