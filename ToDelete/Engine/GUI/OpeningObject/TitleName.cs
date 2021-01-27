using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.GUI.OpeningObject
{
    public class TitleName : GUIObject
    {
        public TitleName(Image img, int posX, int posY, int width, int height) :base(img, posX, posY, width, height)
        {
            this.PosX = PosX;
            originalPosX = PosX;
            this.Active = false;
        }

        int originalPosX;

        public override Image GetImage()
        {
            

            float timeForAnimation = 2;
            if (TimeOfAnimation < timeForAnimation)
            {

                PosX = originalPosX + (int)((Width - ((Width / timeForAnimation) * TimeOfAnimation)));

            }
            else PosX = originalPosX;
            return SourceImage;
        }

        public override void MouseCLick()
        {
            throw new NotImplementedException();
        }
    }
}
