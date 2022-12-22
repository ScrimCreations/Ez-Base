using ApolloCore.API.QM;
using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzBase.Menus
{
    internal class PrimaryMenu
    {
        public static QMTabMenu Main;
        public static void Init()
        {
            Main = new QMTabMenu($"{MainClass.ModName} By {MainClass.ModAuthor}", MainClass.ModName, null);
        }
    }
}
