using Problems_6;

namespace Problem_6
{
    public class Citizens: IBuyer,IBirthday,IId
    {
        public string Name { get; }
        public string Age { get; }
        public string Birthday { get; }
        public string Id { get; }
        
        public int Food { get; private set; }


        public Citizens(string name, string age, string id, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Age = age;
            this.Id = id;
            Food = 0;
        }
        public void BuyFood()
        {
            Food += 5;
        }
        
        

        
    }
}