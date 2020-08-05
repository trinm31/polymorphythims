namespace Problem_5
{
    public class Pet: IPet,IBirthday
    {
        public string Name { get; }
        public string Birthday { get; }

        public Pet(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }
    }
}