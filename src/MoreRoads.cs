using Vintagestory.API.Common;

namespace MoreRoads
{
    public class MoreRoads: ModSystem
    {
        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            api.RegisterBlockClass("BlockConcrete", typeof(BlockConcrete));
        }
    }
}
