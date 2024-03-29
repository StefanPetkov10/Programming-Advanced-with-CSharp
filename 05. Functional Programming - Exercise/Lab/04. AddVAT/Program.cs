﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Func<string, double> parser = s => double.Parse(s);
            Func<double, double> vat = n => n * 1.2;

            List<double> numbers =
                Console.ReadLine().Split(", ")
                .Select(parser)
                .Select(vat).ToList();

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
