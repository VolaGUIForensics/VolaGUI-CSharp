using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace VolaGUI_Final
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault(false);
            volaguiForm mainGUI = new volaguiForm( );
            mainGUI.AddTabs( );
            Application.Run(mainGUI);
            
            //Read in Config File

        }
    }
}
