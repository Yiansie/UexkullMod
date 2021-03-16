using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace UexkullMod.Items.Consumables
{
    class RabbitEssence : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rabbit Essence");
            Tooltip.SetDefault("It has to be done");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4));
            ItemID.Sets.AnimatesAsSoul[item.type] = true;
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
            Item refItem = new Item();
            refItem.SetDefaults(ItemID.SoulofSight);
            item.width = refItem.width;
            item.height = refItem.height;
            item.rare = ItemRarityID.Green;
            item.maxStack = 999;
        }
    }
}
