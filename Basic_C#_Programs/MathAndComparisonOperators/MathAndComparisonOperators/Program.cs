﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MATH OPERATORS

            int total = 5 + 10;
            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine(combined);
            Console.ReadLine();

            int difference = 10 - 5;
            Console.WriteLine("Ten minus Five = " + difference.ToString());
            Console.ReadLine();

            int product = 10 * 5;
            Console.WriteLine(product);
            Console.ReadLine();

            double quotient = 100.0 / 17.0;
            Console.WriteLine(quotient);
            Console.ReadLine();

            int remainder = 11 % 2;
            Console.WriteLine(remainder);
            Console.ReadLine();


            // COMPARISON OPERATORS

            bool trueOrFalse = 12 < 5;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();

            int roomTemperature = 70;
            int currentTemperature = 72;
            //bool isWarm = currentTemperature < roomTemperature;
            //bool isWarm = currentTemperature >= roomTemperature;
            bool isWarm = currentTemperature != roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
