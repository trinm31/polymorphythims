using System.Collections.Generic;
using System.Text;
using Problems_7.Interface;

namespace Problems_7.Class
{
    public class Commando: SpecialSoldier,ICommando
    {
        public Commando(int id, string firstName, string lastName, double salary, string corp, List<IMission> missions) : base(id, firstName, lastName, salary, corp)
        {
            this.Missions = missions;
        }
        public List<IMission> Missions { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString()).AppendLine($"Missions: ");
            foreach (var mission in Missions)
            {
                sb.AppendLine(mission.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}