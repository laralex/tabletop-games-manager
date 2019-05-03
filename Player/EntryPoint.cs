using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Player.GUI;

namespace Player
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
            //Application.Run(new Player.GUI.Login.LoginForm());
            var test = new Player.GUI.Debug.Test();
            //test.Show(new GUI.Application.AppForm());
            Application.Run(test);
            //Application.Run(new GUI.Application.AppForm());

        }
    }
}
