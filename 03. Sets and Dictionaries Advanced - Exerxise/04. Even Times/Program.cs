﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbersCounts = new();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numbersCounts.ContainsKey(number))
                {
                    numbersCounts.Add(number, 0);
                }

                numbersCounts[number]++;
            }

            Console.WriteLine(numbersCounts.Single(nc => nc.Value % 2 == 0).Key);
        }
    }
}
