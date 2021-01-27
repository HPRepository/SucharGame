using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SucharGame.GUI.OpeningObject
{
    public class TitleName : GUIObject
    {
        public TitleName()
            :base(Image.FromFile(@"Image\logo_title.png"), "TitleName", 1280 / 2, 720 / 2, 1280, 720)
        {
            this.ObjectReactions.Add(new Reactions.MoveToOrigin(this, this.Width, 0, 5));
            this.ObjectReactions.Add(new Reactions.Sound(this, @"Sound\censure.mp3",5));

            MyMediaPlayer.Volume = 0.1;

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
