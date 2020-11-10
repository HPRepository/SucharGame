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
    public partial class Form3 : Form
    {
        Form1 myToken;
        public Form3(Form1 token)
        {
            
            InitializeComponent();
            picturePlayerOne.Image = Image.FromFile(@"Image\character\TheKarcz.png");
            picturePlayerTwo.Image = Image.FromFile(@"Image\character\TheSzopa.png");
            pictureLocation.Image = Image.FromFile(@"Image\location\familiada.png");
            myToken = token;
        }

        private void startButton_MouseEnter(object sender, EventArgs e)
        {
            startButton.ForeColor = Color.Red;
        }

        private void startButton_MouseLeave(object sender, EventArgs e)
        {
            startButton.ForeColor = Color.Black;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            myToken.Close();
        }
    }
}
