using System.Collections.Generic;
using System.Text;
using Problems_7.Interface;

namespace Problems_7.Class
{
    public class LeutenantGeneral: Privates ,ILeutenantGeneral
    {
        public LeutenantGeneral(int id, string firstName, string lastName, double salary, List<ISoldier> privates) : base(id, firstName, lastName, salary)
        {
            this.Privates = privates;
        }

        public List<ISoldier> Privates { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString()).AppendLine($"Privates: ");
            foreach (var soldier in this.Privates)
            {
                sb.AppendLine(soldier.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}