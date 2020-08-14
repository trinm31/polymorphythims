namespace Problems_7.Interface
{
    public interface IMission
    {
        string CodeName { get; }
        string State { get; }
        void CompleteteMission();
    }
}