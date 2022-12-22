using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRC;
using static EzBase.Patches.Patch;

namespace EzBase.Patches
{
    internal class Patches
    {
        //Do your patching here
        public static void Init()
        {
            //Where your patches are initialized IF YOU CAN'T TELL ALREADY
            MelonLogger.Msg("Initializing Patches...");

            EasyPatching.EasyPatchMethodPost(typeof(NetworkManager), "Method_Public_Void_Player_0", typeof(Patches), "Join");
            EasyPatching.EasyPatchMethodPost(typeof(NetworkManager), "Method_Public_Void_Player_2", typeof(Patches), "Leave");

            MelonLogger.Msg("Done!");
        }

        private static void Join(Player param_1)
        {
            MelonLogger.Msg(ConsoleColor.Green, "Player Joined: " + param_1.field_Private_APIUser_0.displayName);
        }

        private static void Leave(Player param_1)
        {
            MelonLogger.Msg(ConsoleColor.Red, "Player Left: " + param_1.field_Private_APIUser_0.displayName);
        }
    }
}
