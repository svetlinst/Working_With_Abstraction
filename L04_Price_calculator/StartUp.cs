using System;
using System.Linq;

namespace L04_Price_calculator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            decimal price = decimal.Parse(input[0]);
            int days = int.Parse(input[1]);
            var season = Enum.Parse<Season>(input[2]);
            decimal result = 0;
            if (input.Length==4)
            {
                var discount = Enum.Parse<Discount>(input[3]);
                result = CalculatePrice(price, days, season, discount);

            }
            else
            {
                result = CalculatePrice(price,  days, season);
            }
            Console.WriteLine($"{result:f2}");
        }

        private static decimal CalculatePrice( decimal price,int days, Season season, Discount discount = 0)
        {
            decimal finalPrice = ((price*days)*(int)season)- (((price * days) * (int)season)*(int)discount/100);
            return finalPrice;
        }
    }
}
