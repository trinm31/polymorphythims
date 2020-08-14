using System.Collections.Generic;

namespace Problems_7.Interface
{
    public interface IEngineer: ISpecialisedSoldier
    {
        List<IRepair> Repairs { get; }
    }
}