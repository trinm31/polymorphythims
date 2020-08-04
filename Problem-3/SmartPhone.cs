using System;
using System.Linq;

namespace Problem_3
{
    public class SmartPhone: Phone, IBrowse
    {
        public string Browse(string url)
        {
            if (url.Any(Char.IsDigit))
            {
                return "Invalid URL!";
            }
            else
            {
                return $"Browsing: {url}";
            }
        }
        
        

    }
}