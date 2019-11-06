using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input grade of student #1: ");
            int iOne = int.Parse(Console.ReadLine());
            Console.Write("Input grade of student #2: ");
            int iTwo = int.Parse(Console.ReadLine());
            Console.Write("Input grade of student #3: ");
            int iThree = int.Parse(Console.ReadLine());
            Console.Write("Input grade of student #4: ");
            int iFour = int.Parse(Console.ReadLine());
            Console.Write("Input grade of student #5: ");
            int iFive = int.Parse(Console.ReadLine());
            int x = (iOne + iTwo + iThree + iFour + iFive) / 5;
            Console.WriteLine("Average: " + x);
            Console.ReadKey();
        }
    }
}
