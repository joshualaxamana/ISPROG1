using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiz1LaxamanaJoshua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ISPROG1 Long Quiz#1 - Laxamana, Joshua B.";
            Console.Write("Input your name: ");
            string Name = Console.ReadLine();
            Console.Write("Input 1st number: ");
            int iFirst = int.Parse(Console.ReadLine());
            int x = iFirst;
            Console.Write("Input 2nd number: ");
            int iSecond = int.Parse(Console.ReadLine());
            int y = iSecond;
            Console.WriteLine("------------------");
            Console.Write("SUM:");
            Console.WriteLine(x + y);
            Console.Write("DIFFERENCE:");
            Console.WriteLine(x - y);
            Console.Write("PRODUCT:");
            Console.WriteLine(x * y);
            Console.Write("QUOTIENT:");
            Console.WriteLine(x / y);
            Console.WriteLine("------------------");
            for (int a = iFirst; a <= iSecond; a++)
            {
                Console.WriteLine(a + " =");
            }
            Console.WriteLine("Thank you for playing " + Name);
          
            Console.ReadKey();
        }
    }
}
