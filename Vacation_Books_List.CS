using System;
using System.IO;

namespace vacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int pages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double timeForBooks = pages / pagesPerHour;
            double finalTimeForBooks = timeForBooks / days;
            Console.WriteLine(finalTimeForBooks);

        }
    }
    }
