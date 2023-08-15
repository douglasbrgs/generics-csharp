using Course03.Entities;
using System;

namespace Course03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client()
            {
                Name = "Maria",
                Email = "maria@gmail.com"
            };

            Client b = new Client()
            {
                Name = "Alex",
                Email = "alex@gmail.com"
            };

            //Compara o conteúdo
            Console.WriteLine(a.Equals(b));

            //Compara a referência de memória
            Console.WriteLine(a == b);

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}