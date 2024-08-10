using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IceAndFireMod.Content.Items.Accessories
{
	public class DeathRing : ModItem
	{

		public override void SetDefaults() 
		{
			Item.width = 20;
			Item.height = 20;
			Item.value = 5500;
			Item.rare = ItemRarityID.Cyan;
			Item.accessory = true;
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Melee) += 0.15f;
        }

        public override void AddRecipes() 
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.AdamantiteBar, 5);
			recipe.AddIngredient(ItemID.SoulofNight, 3);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();

			Recipe alternateRecipe = CreateRecipe();
			alternateRecipe.AddIngredient(ItemID.TitaniumBar, 5);
			alternateRecipe.AddIngredient(ItemID.SoulofNight, 3);
			alternateRecipe.AddTile(TileID.TinkerersWorkbench);
			alternateRecipe.Register();
		}
	}
}