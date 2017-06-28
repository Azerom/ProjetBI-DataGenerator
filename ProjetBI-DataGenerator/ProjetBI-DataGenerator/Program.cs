using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBI_DataGenerator
{
    static class Program
    {
        static public string path = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
        static public Config config = Config.LoadConfig(path + @"\config.json");
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
           
        }
    }
}
