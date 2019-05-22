using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GameClient.GUI;

namespace GameClient
{
    static class EntryPoint
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var test = new GameClient.GUI.Application.AppForm();  // Test();
            Application.Run(test);
        }
    }
}
