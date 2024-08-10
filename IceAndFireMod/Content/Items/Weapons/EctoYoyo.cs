using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using IceAndFireMod.Content.Items.Materials;
using IceAndFireMod.Content.Projectiles;


namespace IceAndFireMod.Content.Items.Weapons
{
    public class EctoYoyo : ModItem
    {

        public override void SetDefaults()
        {
            Item.damage = 27;
            Item.crit = 34;
            Item.DamageType = DamageClass.Generic;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 30;
            Item.useAnimation = 32;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 1;
            Item.value = 4000;
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item7;
            Item.autoReuse = true;
            Item.noUseGraphic = true;
            Item.channel = true;
            Item.shoot = ModContent.ProjectileType<EctoYoyoProjectile>();
            Item.shootSpeed = 6f;
            Item.noMelee = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.WoodYoyo);
            recipe.AddIngredient<GhostPlasm>(4);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }

    }
}
