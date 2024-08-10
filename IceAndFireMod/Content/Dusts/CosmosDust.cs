using Terraria;
using Terraria.ModLoader;

namespace IceAndFireMod.Content.Dusts
{
    internal class CosmosDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = true;
            dust.noLight = true;
        }

        public override bool Update(Dust dust)
        {
            dust.position += dust.velocity;
            dust.rotation += dust.velocity.X * 0.15f;
            dust.scale *= 0.90f;
            if(dust.scale < 0.3f)
            {
                dust.active = false;
            }

            return false;
        }
    }
}