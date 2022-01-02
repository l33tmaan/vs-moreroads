namespace MoreRoads
{
    using Vintagestory.API.Common;
    using Vintagestory.API.MathTools;
	public class BlockConcrete : Block, IBlockFlowing
	{
		public string Flow { get; set; }
		public Vec3i FlowNormali { get => null; set {} }
		public bool IsLava => true;

		public BlockConcrete() : base()
		{ }

		public override void OnLoaded(ICoreAPI api)
		{
			base.OnLoaded(api);
		}
	}
}
