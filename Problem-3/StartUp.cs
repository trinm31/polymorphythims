using System;

namespace Problem_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SmartPhone smartPhone = new SmartPhone();
            StaticPhone staticPhone = new StaticPhone();
            string[] phone = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string[] url = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var phoneNumber in phone )
            {
                Console.WriteLine(smartPhone.Phonecheck(phoneNumber));
            }

            foreach (var webUrl in url)
            {
                Console.WriteLine(smartPhone.Browse(webUrl));
            }
            foreach (var phoneNumber in phone)
            {
                Console.WriteLine(staticPhone.Phonecheck(phoneNumber));
            }
        }
    }
}