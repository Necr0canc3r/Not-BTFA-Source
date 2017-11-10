using Terraria;
using Terraria.ModLoader;
//meme
namespace ForgottenMemories.Items.Banner
{
	public class SquidBannerItem : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 10;
			item.height = 24;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.rare = 1;
			item.value = Item.buyPrice(0, 0, 10, 0);
			item.createTile = mod.TileType("SquidBanner");
			item.placeStyle = 1;		//Place style means which frame(Horizontally, starting from 0) of the tile should be placed
		}
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Water Shard Squid Banner");
            Tooltip.SetDefault("");
        }
	}
}
