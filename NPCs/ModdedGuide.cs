using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GSI.NPCs
{
    class ModdedGuide : ModNPC
    {
        public override bool Autoload(ref string name, ref string texture, ref string[] altTextures)
        {
            name = "Guide";
            return mod.Properties.Autoload;
        }

        public override void SetDefaults()
        {
            npc.name = "Guide";
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.defense = 15;
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            Main.npcFrameCount[npc.type] = 25;
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 150;
            NPCID.Sets.AttackType[npc.type] = 1;
            NPCID.Sets.AttackTime[npc.type] = 30;
            NPCID.Sets.AttackAverageChance[npc.type] = 10;
            NPCID.Sets.HatOffsetY[npc.type] = 4;
            animationType = NPCID.Guide;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            return true;
        }

        public override bool CheckConditions(int left, int right, int top, int bottom)
        {
            return true;
        }

        public override string TownNPCName()
        {
            string[] names = { "Andrew", "Asher", "Bradley", "Brandon", "Brett", "Brian", "Cody", "Cole", "Colin", "Connor", "Daniel", "Dylan", "Garret", "Harley", "Jack", "Jacob", "Jake", "Jeff", "Jeffrey", "Joe", "Kevin", "Kyle", "Levi", "Logan", "Luke", "Marty", "Maxwell", "Ryan", "Scott", "Seth", "Steve", "Tanner", "Trent", "Wyatt", "Zach"};

            return names[WorldGen.genRand.Next(names.Length)];
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = "Help";
            button2 = "Crafting";
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            int x = 0;
            Console.WriteLine(1337 / x);
        }

        public override string GetChat()
        {
            //string[] normalQuotes = { "Greetings " + Main.playerPathName + ". Is there something I can help you with?",
            //                        "I am here to give you advice on what to do next. It is recommended that you talk with me anytime you get stuck.",
            //                        "They say there is a person who will tell you how to survive in this land... oh wait. That's me."};
            //string[] bloodmoonQuotes = { "Hey, buddy, do you know where any deathweed is? Oh, no reason; Just wondering, is all.",
            //                           "If you were to look up, you'd see the moon is red right now.",
            //                           "You can tell a Blood Moon is out when the sky turns red. There is something about it that causes monsters to swarm."};

            //if(Main.bloodMoon)
            //{
            //    return bloodmoonQuotes[Main.rand.Next(bloodmoonQuotes.Length)];
            //}
            //else if(!Main.dayTime && Main.rand.Next(normalQuotes.Length) + 1 == normalQuotes.Length + 1)
            //{
            //    return "You should stay indoors at night. It is very dangerous to be wandering around in the dark.";
            //}

            //return normalQuotes[Main.rand.Next(normalQuotes.Length)];

            return "omg";
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 10;
            knockback = 2f;
        }

        public override void DrawTownAttackGun(ref float scale, ref int item, ref int closeness)
        {
            scale = 1f;
            item = ItemID.WoodenBow;
            closeness = 50;
        }


    }
}
