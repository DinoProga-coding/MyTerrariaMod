using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.ModLoader.Utilities;
using IceAndFireMod.Content.Items.Materials;

namespace IceAndFireMod.Content.NPCs.Enemies
{
    internal class CosmosDeath : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.Reaper];


            NPCID.Sets.NPCBestiaryDrawModifiers value = new()
            {
                Velocity = 1f
            };
            NPCID.Sets.NPCBestiaryDrawOffset.Add(Type, value);
        }

        public override void SetDefaults()
        {
            NPC.CloneDefaults(NPCID.Reaper);
            NPC.defense = 10;
            NPC.lifeMax = 500;
            NPC.damage = 28;
            NPC.value = 60f;
            NPC.knockBackResist = 0.5f;


            AIType = NPCID.Ghost;
            AnimationType = NPCID.Reaper;

            Banner = Item.NPCtoBanner(NPCID.Reaper);
            BannerItem = Item.BannerToItem(Banner);
        }

        public override void OnKill()
        {
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ModContent.ItemType<CosmosSplinter>(), Main.rand.Next(0, 4));
        }

         public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.HardmodeJungle.Chance * 15f;
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Times.DayTime,
                new FlavorTextBestiaryInfoElement("He came from outer space for your soul")
            });
        }
    }
}