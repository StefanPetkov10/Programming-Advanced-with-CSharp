﻿using System;

namespace SideEffect
{
    internal class Program
    {
        static int counter = 0;
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 6));
            Add(5, 6);
            Add(5, 6);
            Add(5, 6);
            Add(5, 6);
            Add(5, 6);

            Console.WriteLine(counter);
        }

        static int Add(int a, int b)
        {
            counter++;
            Console.WriteLine("Hello");
            return a + b;
        }
    }
    
}
