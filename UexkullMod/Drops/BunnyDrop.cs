using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace UexkullMod.Drops
{
    public class BunnyDrop : GlobalNPC
    {

        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.Bunny)
            {
                if (Main.rand.NextFloat() < .3303f)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RabbitEssence"));
                }

            }
        }

    }
}
