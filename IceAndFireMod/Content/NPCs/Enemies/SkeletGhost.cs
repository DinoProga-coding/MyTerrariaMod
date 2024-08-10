using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.ModLoader.Utilities;
using IceAndFireMod.Content.Items.Materials;

namespace IceAndFireMod.Content.NPCs.Enemies
{
    internal class SkeletGhost : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.PirateGhost];


            NPCID.Sets.NPCBestiaryDrawModifiers value = new()
            {
                Velocity = 1f
            };
            NPCID.Sets.NPCBestiaryDrawOffset.Add(Type, value);
        }

        public override void SetDefaults()
        {
            NPC.CloneDefaults(NPCID.Ghost);
            NPC.defense = 8;
            NPC.lifeMax = 50;
            NPC.damage = 10;
            NPC.value = 60f;
            NPC.knockBackResist = 0.5f;


            AIType = NPCID.Ghost;
            AnimationType = NPCID.PirateGhost;

            Banner = Item.NPCtoBanner(NPCID.PirateGhost);
            BannerItem = Item.BannerToItem(Banner);
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldNightMonster.Chance * 10f;
        }

        public override void OnKill()
        {
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ModContent.ItemType<GhostPlasm>(), Main.rand.Next(0, 3));
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Times.DayTime,
                new FlavorTextBestiaryInfoElement("Skeleton Ghost")
            });
        }
    }
}