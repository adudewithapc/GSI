using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace GSI
{
    class GSIWorld : ModWorld
    {
        public override void PostWorldGen()
        {
            int moddedGuide = Terraria.NPC.NewNPC(Main.spawnTileX, Main.spawnTileY, mod.NPCType("Modded Guide"));
            Main.npc[moddedGuide].homeTileX = Main.spawnTileX;
            Main.npc[moddedGuide].homeTileY = Main.spawnTileY;
            Main.npc[moddedGuide].direction = 1;
            Main.npc[moddedGuide].homeless = true;
        }

        public override void PreUpdate()
        {
            Main.npc[NPCID.Guide].Teleport(new Vector2(Main.spawnTileX, Main.spawnTileY - int.MaxValue), 0, 0);
        }
    }
}
