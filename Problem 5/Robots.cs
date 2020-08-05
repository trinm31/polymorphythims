namespace Problem_5
{
    public class Robots: IRobots,IId

    {
        public string Model { get; }
        public string Id { get; }

        public Robots(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
    }
}