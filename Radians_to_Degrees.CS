using System;
using System.IO;

namespace radiansToDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double RAD = double.Parse(Console.ReadLine());
            double degrees = RAD * 180 / Math.PI;
            double finalDegrees = Math.Round(degrees);
            Console.WriteLine(finalDegrees);

        }
    }
    }
