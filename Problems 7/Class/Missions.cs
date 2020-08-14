using Problems_7.Interface;

namespace Problems_7.Class
{
    public class Missions: IMission
    {
        public Missions(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }
        public string CodeName { get; }
        public string State { get; private set; }

        public void CompleteteMission()
        {
            this.State = "Finshed";
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}