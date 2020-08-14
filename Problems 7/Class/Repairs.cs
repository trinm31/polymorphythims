using Problems_7.Interface;

namespace Problems_7.Class
{
    public class Repairs: IRepair
    {
        public string PartName { get; }
        public int HoursWorked { get; }

        public Repairs(string partName, int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }

        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
        }
    }
}