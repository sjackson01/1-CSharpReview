﻿using System;

namespace _1_CSharpReview
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Create implicitly typed vars
            var number = 4;
            var greeting = "Hello";

            // Create explicitly typed vars
            string salutation = "Hi";

            // Display and manipulate vars
            Console.WriteLine(number);
            Console.WriteLine(greeting);
            Console.WriteLine(number + 2);
            Console.WriteLine(12 - number);
            Console.WriteLine(salutation);

            // Re-assign value to var assignment
            number = 10;

            Console.WriteLine(12 - number);

            Console.WriteLine(1.GetType());         // System.Int32
            Console.WriteLine(3.14.GetType());      // System.Double
            Console.WriteLine("hello".GetType());   // System.String
            Console.WriteLine(true.GetType());      // System.Boolean
            Console.WriteLine('z'.GetType());       // System.Char

            Console.ReadLine();
        }
    }
}
