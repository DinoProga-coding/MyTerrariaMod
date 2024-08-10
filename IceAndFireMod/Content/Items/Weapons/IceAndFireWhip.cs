using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using IceAndFireMod.Content.Projectiles;

namespace IceAndFireMod.Content.Items.Weapons
{
	public class IceAndFireWhip : ModItem
	{

		public override void SetDefaults()
		{
			Item.DefaultToWhip(ModContent.ProjectileType<IceAndFireWhipProjectile>(), 90, 5, 3);
			Item.shootSpeed = 6;
			Item.rare = ItemRarityID.Green;
			Item.channel = true;
		}

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.FireWhip, 1);
			recipe.AddIngredient(ItemID.CoolWhip, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}

		public override bool MeleePrefix()
		{
			return true;
		}
	}
}