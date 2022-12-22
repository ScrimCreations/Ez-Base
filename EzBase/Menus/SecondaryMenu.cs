using ApolloCore.API.QM;
using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzBase.Menus
{
    internal class SecondaryMenu
    {
        public static void Init()
        {
            // QMSingleButton
            // Paramters: Location (QMNestedButton or QMTabMenu), X Position, Y Position, Button Action, ToolTip Text, [Make Half Button (Boolean)]
            new QMSingleButton(PrimaryMenu.Main, 1, 0, "Button", delegate
            {
                MelonLogger.Msg("Button Clicked");
            }, "This is a button");

            // QMToggleButton
            // Parameters: Location (QMNestedButton or QMTabMenu), X Position, Y Position, Button Text, Toggle On Action, Toggle Off Action, ToolTip Text, [Default Toggle State (Boolean)]
            new QMToggleButton(PrimaryMenu.Main, 2, 0, "Toggle Button", delegate
            {
                MelonLogger.Msg(ConsoleColor.Green, "Button [ON]");
            }, delegate
            {
                MelonLogger.Msg(ConsoleColor.DarkRed, "Button [OFF]");
            }, "This is a toggle button");

            //You can put stuff inside nested buttons very cool
            var AnotherMenu = new QMNestedButton(PrimaryMenu.Main, 3, 0, "Another Menu", "This tooltip goes hard fr fr", "Another Menu");

            new QMSingleButton(AnotherMenu, 1, 0, "Button 1", delegate
            {
                MelonLogger.Msg("Button 1 Clicked");
            }, "This is a button");

            new QMSingleButton(AnotherMenu, 2, 0, "Button 2", delegate
            {
                MelonLogger.Msg("Button 2 Clicked");
            }, "This is a button");

            //You can use richtext
            new QMSingleButton(PrimaryMenu.Main, 1, 1, "<color=#ff00e1>Button</color>", delegate
            {
                MelonLogger.Msg("Button Clicked");
            }, "This is a button");

            new QMSingleButton(PrimaryMenu.Main, 2, 1, "<color=#0084ff><i>Button</i></color>", delegate
            {
                MelonLogger.Msg("Button Clicked");
            }, "This is a button");

            new QMSingleButton(PrimaryMenu.Main, 3, 1, "<color=#ffc800><b>Button</b></color>", delegate
            {
                MelonLogger.Msg("Button Clicked");
            }, "This is a button");
        }
    }
}
