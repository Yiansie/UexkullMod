using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace UexkullMod.Items.Buffs
{
    class UexkullPetBuff : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Uexkull");
            Description.SetDefault("Is that... A bunny?");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<UxModPlayer>().uexkullPet = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("UexkullPetProjectile")] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("UexkullPetProjectile"), 0, 0f, player.whoAmI, 0f, 0f);
            }

        }

    }
}
