﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favorite number" : "You do not have an awesome favorite number";
            Console.WriteLine(result);

            int roomTemperature = 70;

            Console.WriteLine("Hi, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            int currentTemperature = Convert.ToInt32(Console.ReadLine());

            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else if (roomTemperature > currentTemperature)
            {
                Console.WriteLine("It is colder than room temperature.");
            }
            else
            {
                Console.WriteLine("Uhhhhh... something went wrong.");
            }

            int currentTemperature2 = 80;
            int roomTemperature2 = 70;

            string comparisonResults = currentTemperature2 == roomTemperature2 ? "It is room temp." : "It is not room temp.";

            Console.WriteLine(comparisonResults);

            if (currentTemperature2 == roomTemperature2)
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if (currentTemperature2 > roomTemperature2)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else if (roomTemperature2 > currentTemperature2)
            {
                Console.WriteLine("Room temperature is warmer than current temperature.");
            }
            else
            {
                Console.WriteLine("It is not exactly room temperature.");
            }

            Console.ReadLine();
        }
    }
}
