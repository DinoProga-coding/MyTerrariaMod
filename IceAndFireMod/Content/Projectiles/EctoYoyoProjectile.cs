using Terraria;
using Terraria.ModLoader;

namespace IceAndFireMod.Content.Projectiles
{
    public class EctoYoyoProjectile : ModProjectile
    {

        public override void SetDefaults()
        {
            Projectile.DamageType = DamageClass.Melee;
            Projectile.width = 16;
            Projectile.height = 16;
            Projectile.aiStyle = 99;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.penetrate = -1;
        }
    }
}