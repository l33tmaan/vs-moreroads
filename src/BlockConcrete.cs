namespace MoreRoads
{
    using Vintagestory.API.Common;
    using Vintagestory.API.MathTools;
	public class BlockConcrete : Block, IBlockFlowing
	{
		public string Flow { get; set; }
		public Vec3i FlowNormali { get => null; set {} }
        public string Height { get; set; }
		public bool IsLava => true;

		public BlockConcrete() : base()
		{ }

		public override void OnLoaded(ICoreAPI api)
		{
			base.OnLoaded(api);
			Flow = Variant["flow"] is string f ? string.Intern(f) : null; ;
			FlowNormali = Flow != null ? Cardinal.FromInitial(Flow)?.Normali : null;
			Height = Variant["height"] is string h ? string.Intern(h) : null; ;
		}
	}
}
