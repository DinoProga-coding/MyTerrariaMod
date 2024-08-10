using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using IceAndFireMod.Content.Projectiles;
using IceAndFireMod.Content.Items.Materials;

namespace IceAndFireMod.Content.Items.Weapons
{ 
	public class CosmosSword : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 44;
			Item.crit = 22;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 1;
			Item.value = Item.buyPrice(gold: 15);
			Item.rare = ItemRarityID.Green;
			Item.UseSound = SoundID.Item19;
			Item.autoReuse = true;

			Item.shoot = ModContent.ProjectileType<CosmosSwordProjectile>();
            Item.shootSpeed = 10f;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SoulofNight, 4);
			recipe.AddIngredient(ItemID.DemoniteBar, 5);
			recipe.AddIngredient<CosmosSplinter>(4);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();

			Recipe alternateRecipe = CreateRecipe();
			alternateRecipe.AddIngredient(ItemID.SoulofNight, 4);
			alternateRecipe.AddIngredient(ItemID.CrimtaneBar, 5);
			alternateRecipe.AddIngredient<CosmosSplinter>(4);
			alternateRecipe.AddTile(TileID.Anvils);
			alternateRecipe.Register();
		}
	}
}
