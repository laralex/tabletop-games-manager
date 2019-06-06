using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            var test = new GameClient.GUI.Application.AppForm();  // Test();
            System.Windows.Forms.Application.Run(test);
        }
    }
}
