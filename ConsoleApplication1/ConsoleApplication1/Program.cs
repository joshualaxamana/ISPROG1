using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My First Loops - Joshua Laxamana";
            //int iNumber = int.Parse(Console.ReadLine());
            //for (int x = 1; x <= iNumber; x++)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.Write("Input number: ");
            //int iMultiply = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= 15; i++)
            //{
            //    Console.WriteLine(iMultiply + " x " + i + " = " + (iMultiply * i));
            //}
            Console.Write("Input number: ");
            int iAdd = int.Parse(Console.ReadLine());
            for (int a = 0; a <= 6; a++)
            {
                Console.WriteLine(a);
                Console.WriteLine(iAdd + " x " + a + " = " + (iAdd * 2));
           
            }
           
            Console.ReadKey();
        }
    }
}
