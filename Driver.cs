using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sprint_2_GUI_Group1_1
{
    internal static class Driver
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ScreenHost GUISystem = new ScreenHost();
            Application.Run(GUISystem);
        }
    }
}