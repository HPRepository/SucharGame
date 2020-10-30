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
using Engine.Player;
using WMPLib;

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



        }
    }
}
