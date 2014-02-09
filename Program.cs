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
            List<string> commands = new List<string>(); 
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Initialize GUI for Use
            volaguiForm mainGUI = new volaguiForm( );
            mainGUI.AddTabs(commands);
            
            
            Application.Run(mainGUI);
        }
    }
}
