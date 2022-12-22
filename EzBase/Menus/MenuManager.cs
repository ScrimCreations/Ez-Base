using ApolloCore.API.QM;
using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzBase.Menus
{
    internal class MenuManager
    {
        public const string MenuIdent = "YourMenuIdentifier";
        public static void Initialize()
        {
            //Call all your menus in here yes this is messy but screw you
            try { PrimaryMenu.Init(); } catch { MelonLogger.Msg(ConsoleColor.DarkRed, "Main Menu failed to initialize"); }
            try { SecondaryMenu.Init(); } catch { MelonLogger.Msg(ConsoleColor.DarkRed, "Second Menu failed to initialize"); }
        }
    }
}
