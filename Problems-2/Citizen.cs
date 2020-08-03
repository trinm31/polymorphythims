using System;

namespace Problems_2
{
    public class Citizen : IBirthable,IIdentifiable
    {
        private string _birthdate;
        private string _name;
        private int _age;
        public string _id;

        public string Birthdate
        {
            get => _birthdate;
            set => _birthdate = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public string Id
        {
            get => _id;
            set => _id = value;
        }

        public Citizen(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthday;
        }
    }
}