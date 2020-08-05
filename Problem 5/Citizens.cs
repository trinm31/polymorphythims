namespace Problem_5
{
    public class Citizens: ICitizen,IBirthday,IId
    {
        public string Name { get; }
        public string Age { get; }
        public string Birthday { get; }
        public string Id { get; }

        public Citizens(string name, string age, string id, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Age = age;
            this.Id = id;
        }
    }
}