using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.ModLoader.Utilities;

namespace IceAndFireMod.Content.NPCs.Enemies
{
    internal class StrangeFish : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.Goldfish];

            NPCID.Sets.ShimmerTransformToNPC[NPC.type] = NPCID.DukeFishron;

            NPCID.Sets.NPCBestiaryDrawModifiers value = new()
            {
                Velocity = 1f
            };
            NPCID.Sets.NPCBestiaryDrawOffset.Add(Type, value);
        }

        public override void SetDefaults()
        {
            NPC.CloneDefaults(NPCID.Goldfish);
            NPC.defense = 1;
            NPC.lifeMax = 10;
            NPC.value = 30f;
            NPC.knockBackResist = 0.5f;


            AIType = NPCID.Goldfish;
            AnimationType = NPCID.Goldfish;

            Banner = Item.NPCtoBanner(NPCID.Goldfish);
            BannerItem = Item.BannerToItem(Banner);
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Ocean.Chance - 0.6f;
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Times.DayTime,
                new FlavorTextBestiaryInfoElement("Radioactive fish")
            });
        }
    }
}