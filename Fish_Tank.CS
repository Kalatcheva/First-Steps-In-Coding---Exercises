using System;
using System.IO;
using System.Security.Cryptography;
using System.Transactions;

namespace fishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int dyljinaCm = int.Parse(Console.ReadLine());
            int shirochinaCm = int.Parse(Console.ReadLine());
            int visochinaCm = int.Parse(Console.ReadLine());
            double accsesory = double.Parse(Console.ReadLine());

            int obem = dyljinaCm * shirochinaCm * visochinaCm;
            double litVoda = obem * 0.001;
            double procent = accsesory * 0.01;
            double finalLitVoda = litVoda * (1 - procent);

            Console.WriteLine($"{finalLitVoda:f5}");
        }
    }
    }
