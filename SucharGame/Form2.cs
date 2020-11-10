using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace SucharGame
{
    public partial class Form2 : Form
    {
        System.Windows.Forms.Timer t = new Timer();

       
        public Form2()
        {
            t.Interval = 500;
            t.Tick += new EventHandler(LabelBlinking);
            startImage.Image = Image.FromFile(@"startImage.png");
            InitializeComponent();

            t.Start();
            
        }

        void LabelBlinking(object sender, EventArgs e)
        {
            pressAnyKey.Visible = !pressAnyKey.Visible;


        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            this.Close();
        }
    }
}
