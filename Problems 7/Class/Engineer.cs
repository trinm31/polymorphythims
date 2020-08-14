using System.Collections.Generic;
using System.Text;
using Problems_7.Interface;

namespace Problems_7.Class
{
    public class Engineer: SpecialSoldier,IEngineer
    {
        public Engineer(int id, string firstName, string lastName, double salary, string corp, List<IRepair> repairs) : base(id, firstName, lastName, salary, corp)
        {
            this.Repairs = repairs;
        }

        public List<IRepair> Repairs { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString()).AppendLine($"Repair: ");
            foreach (var repair in Repairs)
            {
                sb.AppendLine(repair.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}