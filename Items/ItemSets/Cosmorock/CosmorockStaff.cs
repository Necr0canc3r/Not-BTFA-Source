using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using System;

namespace ForgottenMemories.Items.ItemSets.Cosmorock
{
	public class CosmorockStaff : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 44;
			item.magic = true;

			item.width = 50;
			item.height = 50;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.knockBack = 1;
			item.value = 200000;
			item.rare = 6;
			item.mana = 5;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("CosmorockLaser");
			item.shootSpeed = 11f;
			item.noMelee = true;
			Item.staff[item.type] = true;
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Cosmic Sceptre");
      Tooltip.SetDefault("Fires homing bolts, has a chance to launch a meteor instead");
    }

		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (Main.rand.Next(4) == 0)
			{
				int proj = Projectile.NewProjectile(player.Center.X, player.Center.Y, speedX, speedY, mod.ProjectileType("CosmirockMeteor"), damage, knockBack, player.whoAmI);
				Main.projectile[proj].melee = false;
				Main.projectile[proj].magic = true;
				Main.projectile[proj].timeLeft = 200;
				return false;
			}
			return true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SpaceRockFragment", 12);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
