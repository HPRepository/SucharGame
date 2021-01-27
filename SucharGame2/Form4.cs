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
    public partial class Form4 : Form
    {
        Form1 myToken;
        public Form4(Form1 token)
        {
            
            Image playerOneTMP = Image.FromFile(@"Image\character\TheKarcz.png");
            Image playerTwoTMP = Image.FromFile(@"Image\character\TheSzopa.png");
            Image attackTwo = Image.FromFile(@"Image\attack\combo\patienceisvirgin.png");
            Image attackOne = Image.FromFile(@"Image\attack\combo\kaboom.png");
            Image but1= Image.FromFile(@"Image\button\normalOn.png");
            Image but2 = Image.FromFile(@"Image\button\normalOver.png");
            Image but3 = Image.FromFile(@"Image\button\normalOff.png");
            Image backgroundTMP = Image.FromFile(@"Image\location\familiada.png");
            InitializeComponent();
            myToken = token;
      
            picturePlayerOne.Image = playerOneTMP;
            picturePlayerTwo.Image = playerTwoTMP;
            pictureAttackPlayerTwo.Image = attackTwo;
            pictureAttackPlayerOne.Image = attackOne;
            pictureBox1.Image = but1;
            pictureBox2.Image = but2;
            pictureBox3.Image = but3;
     // this.BackgroundImage = backgroundTMP;




        }

        private void button7_Click(object sender, EventArgs e)
        {

            myToken.Close();
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            
            
        }
    }
}
