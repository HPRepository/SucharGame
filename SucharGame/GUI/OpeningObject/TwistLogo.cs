using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SucharGame.GUI.OpeningObject
{
    public class TwistLogo : GUIObject
    {
        public TwistLogo() : 
            base(Image.FromFile(@"Image\single_logo.png"),"TwistLogo", 696, 333, 287, 305)
        {
            this.ObjectReactions.Add(new Reactions.Sound(this, @"Sound\Familiada_Intro.mp3", 7));

            this.ObjectReactions.Add(new Reactions.RotateAndScale(this, 720, 0, 1,7));
            this.MyMediaPlayer.Play();
        }

        public override void ChangeObject()
        {

        }

        public override void MouseCLick()
        {
            throw new NotImplementedException();
        }
    }
}
