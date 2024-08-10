using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using IceAndFireMod.Content.Dusts;

namespace IceAndFireMod.Content.Projectiles
{
    internal class FireBookProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 50;
            Projectile.height = 50;

            Projectile.friendly = true;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = false;

            Projectile.DamageType = DamageClass.Melee;

            Projectile.aiStyle = -1;

            Projectile.penetrate = -1;
        }

        public override void AI()
        {
            Projectile.ai[0]++;
            if(Projectile.ai[0] < 60f)
            {
                Projectile.velocity *= 1.01f;
            } else
            {
                Projectile.velocity *= 1.04f;
                if(Projectile.ai[0] >= 180)
                {
                    Projectile.Kill();
                }
            }


            Lighting.AddLight(Projectile.Center, 0.75f, 0.75f, 0.75f);

            if(Main.rand.NextBool(2))
            {
                int numToSpawn = Main.rand.Next(3);
                for(int i = 0; i < numToSpawn; i++)
                {
                    Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, ModContent.DustType<FireDust>(), Projectile.velocity.X * 0.1f, Projectile.velocity.Y * 0.1f,
                        0, default(Color), 1f);
                }
            }
        }
    }
}