using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4
{
    internal class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<IID> ids = new List<IID>();
            GetIds(input, ids);
            string lastDigits = Console.ReadLine();
            DetainId(lastDigits, ids);
        }

        private static void DetainId(string lastDigits, List<IID> ids)
        {
            foreach (IID id in ids.Where(i => i.Id.EndsWith(lastDigits)))
            {
                Console.WriteLine(id.Id);
            }
        }

        private static void GetIds(string input, List<IID> ids)
        {
            while (input != "End")
            {
                string[] inputParts = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                if (inputParts.Length == 3)
                {
                    IID citizen = new Citizens(inputParts[0], inputParts[1], inputParts[2]);
                    ids.Add(citizen);
                }
                else if (inputParts.Length == 2)
                {
                    IID robot = new Robots(inputParts[0], inputParts[1]);
                    ids.Add(robot);
                }
                input = Console.ReadLine();
            }
        }
    }
}