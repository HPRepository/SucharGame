using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;
using Engine.Players;
using Engine.AttackClass.RegularAttack.KarczuAttack;
using Engine.AttackClass.AttackAdminister.ComboAttackLists;
using WMPLib;
using Engine.AttackClass;


namespace SucharGame
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer myPlayer = new WindowsMediaPlayer();

       
        public Form1()
        {
            InitializeComponent();
            myPlayer.URL = "Powerup.mp3";
            myPlayer.controls.play();

            Form tmp = new Form3(this);

            tmp.MdiParent = this;
            tmp.Dock = DockStyle.Fill;

            tmp.Show();

           

        }

       
    }
}
