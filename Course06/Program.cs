using Course.Entities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Course06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> products = new HashSet<Product>();
            products.Add(new Product("TV",900.0));
            products.Add(new Product("Notebook", 1200.0));

            //Tipo referência: Necessário implementar GetHashCode e Equals
            Product prod = new Product("TV", 900.0);
            Console.WriteLine(products.Contains(prod));

            HashSet<Point> points = new HashSet<Point>();
            points.Add(new Point(3, 4));
            points.Add(new Point(5, 10));

            //Tipo valor (struct) : Compara diretamente os atributos
            Point p = new Point(3, 4);
            Console.WriteLine(points.Contains(p));
        }
    }
}
