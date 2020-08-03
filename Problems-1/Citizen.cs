namespace interface_abstract_exercise
{
    public class Citizen: IPerson
    {
        private string _name;
        public string Name  
        {
            get => _name;
            set => _name = value;
        }
        private int _age;
        public int Age  
        {
            get => _age;
            set => _age = value;
        }

        public Citizen(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}