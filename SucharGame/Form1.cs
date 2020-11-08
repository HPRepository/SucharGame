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
using Engine.AttackClass.AttackAdminister.ComboAttackList;
using WMPLib;
using Engine.AttackClass;

namespace SucharGame
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer myPlayer = new WindowsMediaPlayer();

        List<Type> aa1 = new List<Type>() { typeof(BasicAttackKarcz), typeof(BasicAttackKarcz), typeof(BasicAttackKarcz) };
        Type[] myType = { typeof(BasicAttackKarcz), typeof(BasicAttackKarcz), typeof(BasicAttackKarcz) };
        Type[] myType2 = { typeof(BasicAttackKarcz), typeof(BasicAttackKarcz), typeof(BasicAttackKarcz) };

        int[] a1 = { 1, 2, 3 };
        int[] a2 = { 1, 2, 3 };

        public Form1()
        {
            InitializeComponent();
            myPlayer.URL = "Powerup.mp3";
            myPlayer.controls.stop();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(a1==a2)
            textBox1.Text = typeof(BasicAttackKarcz).Name;

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
