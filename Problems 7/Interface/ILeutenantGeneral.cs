using System.Collections.Generic;

namespace Problems_7.Interface
{
    public interface ILeutenantGeneral: IPrivate
    {
        List<ISoldier> Privates { get; }
    }
}