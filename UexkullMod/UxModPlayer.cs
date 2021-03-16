using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UexkullMod
{
    class UxModPlayer : ModPlayer
    {
        
        public bool uexkullPet;

        public override void ResetEffects()                 //Resetea todas las variables a default
        {
            uexkullPet = false;
        }
    }
}
