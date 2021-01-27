using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SucharGame
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new GameEngine("SucharGame", 1280, 720).Play(new SucharGame.GUI.OpeningObject.OpeningStage(1280, 720), 30);

            //Application.Run(new Form1());
        }
    }
}
