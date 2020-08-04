namespace Problem_4
{
    public class Citizens: ICitizens,IID
    {
        public string Name { get; }
        public string Age { get; }
        public string Id { get; }

        public Citizens(string name, string age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }
    }
}