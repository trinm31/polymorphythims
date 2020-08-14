using System.Globalization;
using System.Net.Http.Headers;
using System.Text;
using Problems_7.Interface;

namespace Problems_7.Class
{
    public class SpecialSoldier: Privates, ISpecialisedSoldier
    {
        public SpecialSoldier(int id, string firstName, string lastName, double salary, string corp) : base(id, firstName, lastName, salary)
        {
            this.Corp = corp;
        }

        public string Corp { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .Append($"Mission: {Corp}");
            return sb.ToString();
        }
    }
}