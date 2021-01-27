using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine.GUI;

namespace GameEngine
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

           

            new Game("SucharGame", 1280, 720).
                Play(new OpeningStage(1280, 720),120);
            //Application.Run(new GameEngine());
        }
    }
}
