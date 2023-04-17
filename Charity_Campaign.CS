using System;
using System.IO;
using System.Security.Cryptography;
using System.Transactions;

namespace charityCampaign
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            int sweatPeople = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            decimal cakesPrice = cakes * 45;
            decimal wafflesPrice = waffles * 5.8m;
            decimal pancakesPrice = pancakes * 3.2m;

            decimal priceForOneDay = (cakesPrice + wafflesPrice + pancakesPrice) * sweatPeople;
            decimal priceForTheEvent = priceForOneDay * days;
            decimal FinalPrice = priceForTheEvent * (7m / 8m);

            Console.WriteLine($"{FinalPrice:f2}");


        }
    }
}
