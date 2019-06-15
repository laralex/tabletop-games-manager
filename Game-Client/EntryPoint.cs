
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using GameClient.Application;

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
            var auth = new AuthenticationBackend();
            // first_form = new GameClient.GUI.Login.LoginForm(); 
            //var first_form = new GameClient.GUI.Application.AppFormDemo();  
            System.Windows.Forms.Application.Run(auth.FrontEndForm);
        }
    }
}
