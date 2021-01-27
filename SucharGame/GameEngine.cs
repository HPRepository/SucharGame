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

namespace SucharGame
{
    public partial class GameEngine : Form
    {
        
            public static GameEngine Engine;

            static List<Keys> PressedKeys = new List<Keys>();

            public static GUIStage CurrentStage { get; private set; }
            public static GUIStage NextStage { get; private set; }

            private GameEngine()
            {
                this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameEngine_KeyDown);
                this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameEngine_KeyUp);
                this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                                ControlStyles.OptimizedDoubleBuffer | ControlStyles.Opaque, true);
                this.StartPosition = FormStartPosition.CenterScreen;
                Engine = this;

            }

            public GameEngine(string title, int width, int height) : this()
            {
                this.ClientSize = new System.Drawing.Size(width, height);
                this.Text = title;
                this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            }

            public GameEngine(string title) : this()
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

            public static void LoadStage(GUIStage newStage)
            {
                NextStage = newStage;
            }

            public void Play(GUIStage firstStage, int maxFPS = 30)
            {
                LoadStage(firstStage);
                this.Show();
                Graphics frontFrame = Graphics.FromHwnd(this.Handle);
                DateTime lastFrameTime = DateTime.Now;
                double timePerFrame = 1000 / maxFPS;

                while (true)
                {
                    if (!this.Created) break;
                    if (NextStage != null) 
                    {
                        CurrentStage = NextStage;
                        NextStage = null;
                        CurrentStage.Start();
                    }

                    float dt = (float)(DateTime.Now - lastFrameTime).TotalSeconds;  
                    lastFrameTime = DateTime.Now;

                    CurrentStage.Update(dt);
                    CurrentStage.ClearBackFrame();
                    CurrentStage.Render();
                    CurrentStage.PasteToFrontBuffor(frontFrame, new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height));


                    Application.DoEvents();
                    double pause = timePerFrame - (DateTime.Now - lastFrameTime).TotalMilliseconds; 
                    if (pause > 0) System.Threading.Thread.Sleep((int)pause);
                }

            }


        }
    }

