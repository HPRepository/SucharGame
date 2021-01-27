using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SucharGame.GUI;

namespace GameEngine
{
    public partial class Game : Form
    {
        public static Game Engine;

        static List<Keys> PressedKeys = new List<Keys>();
       
        public static GUIStage CurrentStage{ get; private set; }
        public static GUIStage NextStage { get; private set; }

        private Game()
        {
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameEngine_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameEngine_KeyUp);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                            ControlStyles.OptimizedDoubleBuffer | ControlStyles.Opaque, true);
            this.StartPosition = FormStartPosition.CenterScreen;
            Engine = this;

        }

        public Game(string title, int width, int height) : this()
        {
            this.ClientSize = new System.Drawing.Size(width, height);
            this.Text = title;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            
        }

        public Game(string title) : this()
        {
            this.Text = title;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            
        }

        private void GameEngine_KeyDown(object sender, KeyEventArgs e)
        {
            if (!PressedKeys.Contains(e.KeyCode)) PressedKeys.Add(e.KeyCode);
        }

        private void GameEngine_KeyUp(object sender, KeyEventArgs e)
        {
            PressedKeys.Remove(e.KeyCode);
        }

        public static void LoadStage (GUIStage newStage)
        {
            NextStage = newStage;
        }

        public void Play(GUIStage firstStage, int maxFPS=30)
        {
            LoadStage(firstStage);
            this.Show();
            Graphics frontFrame = Graphics.FromHwnd(this.Handle);
            DateTime lastFrameTime = DateTime.Now;
            double timePerFrame = 1000 / maxFPS;

            while (true)
            {
                if (!this.Created) break;
                if (NextStage != null)   //na poczatek mozemy zaladowac kolejna scene jesli jest taka potrzeba
                { 
                    CurrentStage = NextStage;
                    NextStage = null;
                    CurrentStage.Start(); 
                }

                float dt = (float)(DateTime.Now - lastFrameTime).TotalSeconds;  //obliczamy czas dt od ostatniej klatki
                lastFrameTime = DateTime.Now; //kolejne dt bedzie liczone wzgledem tej chwili

                CurrentStage.Update(dt);
                CurrentStage.ClearBackFrame();
                CurrentStage.Render();
                CurrentStage.PasteToFrontBuffor(frontFrame, new Rectangle(0,0, this.ClientSize.Width, this.ClientSize.Height));
                

                Application.DoEvents(); //odpowiada za responsywnosc okna, np. zdarzenia wcisniecia klawiszy
                double pause = timePerFrame - (DateTime.Now - lastFrameTime).TotalMilliseconds; //kontrola FPS
                if (pause > 0) System.Threading.Thread.Sleep((int)pause);   //jesli skonczylismy wczesniej to mamy przerwe
            }

        }


    }
}
