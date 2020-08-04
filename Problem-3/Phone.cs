using System.Linq;

namespace Problem_3
{
    public abstract class Phone
    {
        public string Phonecheck(string phoneNumber)
        {
            if (phoneNumber.All(char.IsDigit))
            {
                if (phoneNumber.Length == 10)
                {
                    return $"Calling... {phoneNumber}";
                }
                else if (phoneNumber.Length == 7)
                {
                    return $"Dialing... {phoneNumber}";
                }
                else
                {
                    return $"Invalid Number";
                }
            }
            else
            {
                return $"Invalid Number";
            }
        }
    }
}