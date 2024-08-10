using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using IceAndFireMod.Content.Items.Materials;

namespace IceAndFireMod.Content.Items.Weapons
{
    internal class EctoBow : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 42;
            Item.height = 30;

            Item.useTime = 17;
            Item.useAnimation = 14;

            Item.useStyle = ItemUseStyleID.Shoot;

            Item.autoReuse = true;

            Item.UseSound = SoundID.Item132;

            Item.DamageType = DamageClass.Ranged;
            Item.damage = 24;
            Item.crit = 4;
            Item.knockBack = 2f;
            Item.noMelee = true;

            Item.shoot = ProjectileID.FireArrow;
            Item.shootSpeed = 9f;

            Item.useAmmo = AmmoID.Arrow;
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.CrimtaneBar, 5);
            recipe.AddIngredient(ItemID.TissueSample, 4);
            recipe.AddIngredient<GhostPlasm>(6);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();

            Recipe alternateRecipe = CreateRecipe();
			alternateRecipe.AddIngredient(ItemID.DemoniteBar, 5);
            alternateRecipe.AddIngredient(ItemID.ShadowScale, 4);
            alternateRecipe.AddIngredient<GhostPlasm>(6);
			alternateRecipe.AddTile(TileID.Anvils);
			alternateRecipe.Register();
		}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-4f, 2f);
        }
    }
}