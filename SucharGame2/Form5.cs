using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine.GUI;

namespace SucharGame
{
    public partial class Form5 : Form
    {


        LetsTry myGR;
        float startTime = DateTime.Now.Second;
        float lastTime=DateTime.Now.Second;
        
        public Form5()
        {
            InitializeComponent();

            myGR = new LetsTry(Image.FromFile(@"Image\character\TheSzopa.png"), 0, 0, 5,2);
        

        }

        private void Form5_Paint(object sender, PaintEventArgs e)
        {
            Graphics frontBuffer = Graphics.FromHwnd(this.Handle);

            
            frontBuffer.DrawImage(myGR.GetImage(1), myGR.PosX, myGR.PosY);

            textBox1.Text = myGR.TimeOfAnimation.ToString();
            
        }
    }
}
