using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Problems_7.Interface;

namespace Problems_7.Class
{
    public class Privates : Soldier,IPrivate
    {
        public Privates(int id, string firstName, string lastName, double salary) : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public double Salary { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .Append($"Salary: {this.Salary}");
            return sb.ToString();
        }
    }
}