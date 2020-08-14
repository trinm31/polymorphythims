using Problem_6;

namespace Problems_6
{
    public class Rebel: IBuyer
    {
        public string Name { get; }
        public string Age { get; }
        public string Group { get; }
        public int Food { get; private set; }

        public Rebel(string name, string age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Food = 0;
            this.Group = group;
            
        }
        
        public void BuyFood()
        {
            Food += 5;
        }
    }
}