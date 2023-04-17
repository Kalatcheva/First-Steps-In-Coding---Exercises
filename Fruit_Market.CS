using System;
using System.IO;
using System.Security.Cryptography;
using System.Transactions;

namespace fruitMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananaKg = double.Parse(Console.ReadLine());
            double orangeKg = double.Parse(Console.ReadLine());
            double maliniKg = double.Parse(Console.ReadLine());
            double strawberryKg = double.Parse(Console.ReadLine());

            double maliniPrice = strawberryPrice / 2;
            double orangePrice = maliniPrice - (0.4 * maliniPrice);
            double bananaPrice = maliniPrice - (0.8 * maliniPrice);

            double maliniFinalPrice = maliniKg * maliniPrice;
            double orangeFinalPrice = orangeKg * orangePrice;
            double bananaFinalPrice = bananaKg * bananaPrice;
            double strawberryFinalPrice = strawberryKg * strawberryPrice;

            double finalPrice = maliniFinalPrice + orangeFinalPrice + bananaFinalPrice + strawberryFinalPrice;
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
    }
