using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using UexkullMod.Items.Consumables;

namespace UexkullMod.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    class UexkullArmorHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Uexkull Helmet");
            Tooltip.SetDefault("Armor Set: Jump Boost");
        }

        public override void SetDefaults()
        {
            item.Size = new Vector2(18);
            item.rare = ItemRarityID.Green;
            item.value = Item.sellPrice(silver: 1);
            item.maxStack = 1;
            item.defense = 2;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<RabbitEssence>(), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<UexkullArmorChestplate>() && legs.type == ItemType<UexkullArmorGreaves>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.jumpBoost = true;
        }
    }
}
