using EzBase.Menus;
using MelonLoader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using Mod = EzBase.MainClass.MyMod;

[assembly: MelonInfo(typeof(Mod), "EzBase", "1.0", "Scrim")]
[assembly: MelonGame("VRChat", "VRChat")]

[assembly: MelonColor(ConsoleColor.Cyan)] //Your Mod color
[assembly: MelonAuthorColor(ConsoleColor.Magenta)] //Your Author color
[assembly: MelonPriority(0)] //Leave it at 0 to load your mod before anyone else's (because we are just better)

namespace EzBase
{
    public class MainClass
    {
        public static string ModName = "EzBase";
        public static string ModAuthor = "Scrim";
        public class MyMod : MelonMod
        {
            public override void OnInitializeMelon()
            {
                //When your mod starts lol
                Patches.Patches.Init();
                MelonCoroutines.Start(WaitForQuickMenu());
            }

            public override void OnUpdate()
            {
                //Called every frame
            }

            public override void OnSceneWasInitialized(int buildIndex, string sceneName)
            {
                //Shit happens when Scene inits
            }

            public override void OnSceneWasLoaded(int buildIndex, string sceneName)
            {
                //Shit happens when Scene loads
            }

            private static IEnumerator WaitForQuickMenu()
            {
                while (UnityEngine.Object.FindObjectOfType<VRC.UI.Elements.QuickMenu>() == null) yield return null;
                new WaitForSeconds(0.259f);
                MenuManager.Initialize();
                yield break;
            }

            public override void OnApplicationQuit()
            {
                MelonPreferences.Save(); //Saves yo melonshit if you use melonprefs
                Thread.Sleep(542);
                Process.GetCurrentProcess().Kill(); //Closes the game faster
            }
        }
    }
}
