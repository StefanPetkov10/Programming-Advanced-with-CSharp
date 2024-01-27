﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>() { 1, 2, 3, 4 };
            numbers = numbers.Where((int x) =>
            {
                Console.WriteLine("Checking is Odd");
                return true;
            }).ToList();

            numbers.ForEach((int x) => Console.WriteLine(x));


           // var lambda = (int x) => Console.WriteLine(x);

            bool IsOdd(int x)
            {
                return true;
            }
        }
    }
}
