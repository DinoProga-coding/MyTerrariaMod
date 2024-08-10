using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using IceAndFireMod.Content.Projectiles;

namespace IceAndFireMod.Content.Items.Weapons
{ 
	public class ApocalypsisSword : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 70;
			Item.DamageType = DamageClass.Melee;
			Item.crit = 12;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 1;
			Item.value = Item.buyPrice(gold: 20);
			Item.rare = ItemRarityID.Green;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;

			Item.shoot = ModContent.ProjectileType<ApocalypsisSwordProjectile>();
            Item.shootSpeed = 6f;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SoulofFright, 5);
			recipe.AddIngredient(ItemID.HellstoneBar, 7);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}
