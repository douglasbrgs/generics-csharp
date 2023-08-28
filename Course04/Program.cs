﻿using System;
using System.Collections.Generic;

namespace Course04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Computer"));

            foreach (string item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
