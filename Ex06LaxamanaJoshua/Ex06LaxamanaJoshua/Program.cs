using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex06LaxamanaJoshua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercise #6 - Laxamana, Joshua";
            //DisplaySum(1, 2, 3);
            //DisplayDifference(3, 2);
            //DisplayProduct(5, 5);
            //DisplayQuotient(20, 2);
            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(IsLegal(10));
            //Console.WriteLine(GetAverage(79, 85, 60, 95));
            Console.WriteLine(Fam.DisplayText());
            Console.ReadKey();
        }
        // public void
        // private void
        // protected void

        /// <summary>
        /// Display current date using dd/MM/yyyy format
        /// </summary>
        static void OutputFormattedDate()
        {
            DateTime pogiAko = DateTime.Now;
            Console.WriteLine(pogiAko.ToString("dd/MM/yyyy"));
        
        }

        /// <summary>
        /// Display the sum of two numbers
        /// </summary>
        /// <param name="first">First number to be added</param>
        /// <param name="second">Second number to be added</param>
        static void DisplaySum(int first, int second, int third)
        {
            Console.WriteLine(first + second + third);
        
        }

        /// <summary>
        /// Display the difference of two numbers
        /// </summary>
        /// <param name="first">First number to be subtracted</param>
        /// <param name="second">Second numbert to be substracted</param>
        static void DisplayDifference(int first, int second)
        {
            Console.WriteLine(first - second);

        }

        /// <summary>
        /// Display the product of two numbers
        /// </summary>
        /// <param name="first">First number to be multiplied</param>
        /// <param name="second">Second number to be multiplied</param>
        static void DisplayProduct(int first, int second)
        {
            Console.WriteLine(first * second);

        }

        /// <summary>
        /// Display the quotient of two numbers
        /// </summary>
        /// <param name="first">First number to be divided</param>
        /// <param name="second">Second number to be divided</param>
        static void DisplayQuotient(int first, int second)
        {
            Console.WriteLine(first / second);

        }

        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
        
        }

        static string IsLegal(int age)
        {
            if (age >= 18)
                return "Legal!";
            else
                return "Too young!";

        
        }

        /// <summary>
        /// Get the average of the grades
        /// </summary>
        /// <param name="first">Grade from 1st grading</param>
        /// <param name="second">Grade from 2nd grading</param>
        /// <param name="third">Grade from 3rd grading</param>
        /// <param name="fourth">Grade from 4th grading</param>
        /// <returns>Average score</returns>
        static double GetAverage(int first, int second, 
            int third, int fourth)
        {
            double dAverage = (first + second + third + fourth) / 4;
            return dAverage;
        
        }
    }
}
