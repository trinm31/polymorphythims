using Problems_7.Interface;

namespace Problems_7.Class
{
    public class Soldier: ISoldier
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public Soldier(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = firstName;
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
        }
    }
}