using System;

namespace Eat.Mapping
{
    interface IMapper<TSourceEntity, TTargetEntity>
    {
        void Map(TSourceEntity source, TTargetEntity target);
        TTargetEntity Map(TSourceEntity source);
    }
}
