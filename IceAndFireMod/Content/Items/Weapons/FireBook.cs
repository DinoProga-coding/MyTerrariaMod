using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using IceAndFireMod.Content.Projectiles;


namespace IceAndFireMod.Content.Items.Weapons
{
    internal class FireBook : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 28;
            Item.useStyle = ItemUseStyleID.Shoot;

            Item.DamageType = DamageClass.Magic;
            Item.noMelee = true;
            Item.mana = 6;
            Item.damage = 36;
            Item.crit = 9;
            Item.knockBack = 2.2f;

            Item.useTime = 18;
            Item.useAnimation = 15;

            Item.UseSound = SoundID.Item69;

            Item.shoot = ModContent.ProjectileType<FireBookProjectile>();
            Item.shootSpeed = 3f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DemonScythe, 1);
            recipe.AddIngredient(ItemID.HellstoneBar, 5);
            recipe.AddTile(TileID.Bookcases);
            recipe.Register();
        }
    }
}