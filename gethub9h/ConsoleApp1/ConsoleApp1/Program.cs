﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = new List<string>();
            dogs.Add("bulldog");
            dogs.Add("collie");
            dogs.Add("retriever");
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog + "  ");
            }
            Console.WriteLine(dogs[1]);
            int[] a1 = new int[] { 1, 3, 5, 7, 9, 11 };
            foreach(int i in a1)
            {
                Console.WriteLine(i + "value  ");
            }
        }
    }
}
