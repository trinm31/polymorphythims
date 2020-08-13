using System;
using System.Collections.Generic;
using System.Linq;
using Problem_6;


namespace Problems_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<IBuyer> mainbuyers = new List<IBuyer>();
            ParseInput(mainbuyers);
            ParseBuyer(mainbuyers);
            PrintCostFood(mainbuyers);
            Console.ReadKey();
        }

        public static void PrintCostFood(List<IBuyer> buyers)
        {
            var TotalCost = buyers.Sum(b => b.Food);
            Console.WriteLine(TotalCost);
        }

        public static void ParseBuyer(List<IBuyer> buyers)
        {
            var name = Console.ReadLine();
            while (name.ToLower() != "end")
            {
                foreach (var buyer in buyers)
                {
                    if (buyer.Name == name)
                    {
                        buyer.BuyFood();
                    }
                }
                name = Console.ReadLine();
            }
        }
        
        public static void ParseInput(List<IBuyer> buyers)
        {
            var input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                string[] inputPart = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                switch (inputPart.Length)
                {
                    case 4:
                        IBuyer citizens = new Citizens(inputPart[0],inputPart[1], inputPart[2], inputPart[3]);
                        buyers.Add(citizens);
                        break;
                    case 3:
                        IBuyer rebel = new Rebel(inputPart[0],inputPart[1],inputPart[2]);
                        buyers.Add(rebel);
                        break;
                }

            }
        }
    }
}