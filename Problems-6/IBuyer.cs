using Problem_6;

namespace Problems_6
{
    public interface IBuyer: ICitizen
    {
        int Food { get; }
        void BuyFood();
    }
}