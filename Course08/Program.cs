using Course08.Entities;
using System;
using System.Collections.Generic;

namespace Course08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> courseA = new HashSet<Student>();
            HashSet<Student> courseB = new HashSet<Student>();
            HashSet<Student> courseC = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                int enrollment = int.Parse(Console.ReadLine());
                courseA.Add(new Student(enrollment));
            }

            Console.Write("How many students for course B? ");
            quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                int enrollment = int.Parse(Console.ReadLine());
                courseB.Add(new Student(enrollment));
            }

            Console.Write("How many students for course C? ");
            quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                int enrollment = int.Parse(Console.ReadLine());
                courseC.Add(new Student(enrollment));
            }

            HashSet<Student> totalStudents = new HashSet<Student>();
            totalStudents.UnionWith(courseA);
            totalStudents.UnionWith(courseB);
            totalStudents.UnionWith(courseC);

            Console.WriteLine($"Total students: {totalStudents.Count}");
        }
    }
}
