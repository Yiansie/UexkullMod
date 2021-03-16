using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using UexkullMod.Items.Consumables;

namespace UexkullMod.Items.Pets
{
    class UexkullPetItem : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Illusion Fragment");
            Tooltip.SetDefault("Summons the Pure Illusion king");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ShadowOrb);
            item.width = 32;
            item.height = 32;
            item.rare = ItemRarityID.Expert;
            item.maxStack = 1;
            item.shoot = mod.ProjectileType("UexkullPetProjectile");
            item.buffType = mod.BuffType("UexkullPetBuff");
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<RabbitEssence>(), 20);
            recipe.AddIngredient(ItemID.GoldBunny);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }

    }
}
