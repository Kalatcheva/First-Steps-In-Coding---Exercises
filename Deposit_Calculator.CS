using System;
using System.IO;

namespace depositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double deposit = double.Parse(Console.ReadLine());
            int dueDate = int.Parse(Console.ReadLine());
            double yearlyPercent = double.Parse(Console.ReadLine());
            double lihva = deposit * (yearlyPercent / 100);
            double lihvaMesec = lihva / 12;
            double finalSum = deposit + (dueDate * lihvaMesec);
            Console.WriteLine(finalSum);

        }
    }
    }
