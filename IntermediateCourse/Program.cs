using IntermediateCourse;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StopWatch Stopwatch = new();
            string flag = "s";
            int option = 0;

            while(flag == "s")
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Do you want to start Or Stop? 0/1");
                    option = Int32.Parse(Console.ReadLine());

                    switch (option) { 
                        case 0: Stopwatch.Start(); break;
                        case 1: Console.WriteLine(Stopwatch.Stop()); break;
                        default: return;
                    }
                }
                Console.WriteLine("Do you want to continue?");
                flag = Console.ReadLine();
            }
            
        }
    }
}