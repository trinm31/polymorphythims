using System.Collections.Generic;

namespace Problems_7.Interface
{
    public interface ICommando : ISpecialisedSoldier
    {
        List<IMission> Missions { get; }
    }
}