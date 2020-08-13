using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] arr = new String[10];
            List<IBirthday> birthdays1 = new List<IBirthday>();
            ParseInput(birthdays1);
            string PrintYear = Console.ReadLine();
            PrintBirthDay(birthdays1, PrintYear);
            Console.ReadKey();
        }
        
        public static void PrintBirthDay(List<IBirthday> birthdays,string PrintYear)
        {
            foreach (IBirthday birthday in birthdays.Where(r => r.Birthday.EndsWith(PrintYear)))
            {
                Console.WriteLine(birthday.Birthday);
            }
        }
        
        

        public static void ParseInput(List<IBirthday> birthdays)
        {
            var input = Console.ReadLine();
            while (input.ToLower() != "end")
            {
                string[] InputPart = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                switch (InputPart[0].ToLower())
                {
                    case "citizen":
                        IBirthday citizen = new Citizens(InputPart[1],InputPart[2],InputPart[3],InputPart[4]);
                        birthdays.Add(citizen);
                        break;
                    case "pet":
                        IBirthday pet = new Pet(InputPart[1],InputPart[2]);
                        birthdays.Add(pet);
                        break;
                }
                
                input = Console.ReadLine();
                Console.ReadLine();

                
            }
            
        }
    }
}