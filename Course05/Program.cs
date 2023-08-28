using System;
using System.Collections.Generic;

namespace Course05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> setA = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };

            SortedSet<int> setB = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            // union
            SortedSet<int> setC = new SortedSet<int>(setA);
            setC.UnionWith(setB);
            PrintCollection(setC);

            //intersection
            SortedSet<int> setD = new SortedSet<int>(setA);
            setD.IntersectWith(setB);
            PrintCollection(setD);

            //difference
            SortedSet<int> setE = new SortedSet<int>(setA);
            setE.ExceptWith(setB);
            PrintCollection(setE);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
