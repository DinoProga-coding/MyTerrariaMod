using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using IceAndFireMod.Content.Projectiles;

namespace IceAndFireMod.Content.Items.Weapons
{
	public class IceWhip : ModItem
	{

		public override void SetDefaults()
		{
			Item.DefaultToWhip(ModContent.ProjectileType<IceAndFireWhipProjectile>(), 24, 5, 3);
			Item.shootSpeed = 5;
			Item.rare = ItemRarityID.Green;
			Item.channel = true;
		}

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IceBlock, 40);
			recipe.AddIngredient(ItemID.SnowBlock, 15);
			recipe.AddIngredient(ItemID.DemoniteBar, 7);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();

			Recipe alternateRecipe = CreateRecipe();
			alternateRecipe.AddIngredient(ItemID.IceBlock, 40);
			alternateRecipe.AddIngredient(ItemID.SnowBlock, 15);
			alternateRecipe.AddIngredient(ItemID.CrimtaneBar, 7);
			alternateRecipe.AddTile(TileID.Anvils);
			alternateRecipe.Register();
		}

		public override bool MeleePrefix()
		{
			return true;
		}
	}
}