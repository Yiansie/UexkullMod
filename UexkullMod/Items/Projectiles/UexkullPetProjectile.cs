using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace UexkullMod.Items.Projectiles
{
    public class UexkullPetProjectile : ModProjectile
    {

        public override void SetStaticDefaults()
        {
            Main.projFrames[projectile.type] = 8;              //Frames de la animación
            Main.projPet[projectile.type] = true;              //Marca el proyectil como pet
        }

        public override void SetDefaults()                      //Comportamiento de la pet (Copiado de otra)
        {
            projectile.CloneDefaults(ProjectileID.Bunny);
            aiType = ProjectileID.Bunny;
            projectile.width = 36;
            projectile.height = 36;
        }


        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.bunny = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            UxModPlayer modPlayer = player.GetModPlayer<UxModPlayer>();
            if (player.dead)                                                            //Cuando muere el jugador, se desactiva la pet
            {
                modPlayer.uexkullPet = false;
            }
            if (modPlayer.uexkullPet)
            {
                projectile.timeLeft = 2;
            }
        }

    }
}
