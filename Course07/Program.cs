using System;
using System.Collections.Generic;
using System.IO;
using Course07.Entities;

namespace Course07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter file full path: ");
                string path = Console.ReadLine();

                HashSet<LogRecord> logRecords = new HashSet<LogRecord>();

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);

                        logRecords.Add(new LogRecord(name, instant));
                    }

                    Console.WriteLine("Total users: " + logRecords.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
