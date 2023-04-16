using System;
using System.IO;

namespace USD_To_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double USD = double.Parse(Console.ReadLine());
            double BGN = USD * 1.7954;
            Console.WriteLine($"{BGN}:f2");

        }
    }
    }
