namespace Problem_4
{
    public class Robots: IRobots,IID
    {
        public string RobotId { get; }
        public string Id { get; }

        public Robots(string robotId, string id)
        {
            this.RobotId = robotId;
            this.Id = id;
        }
    }
}