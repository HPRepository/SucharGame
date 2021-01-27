using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.GUI.OpeningObject
{
    public class TwistLogo : GUIObject
    {
        public TwistLogo(Image img, int posX, int posY, int width, int height) : base(img, posX, posY, width, height)
        { }

        public override Image GetImage()
        {
            
            float degreePerSecond = (360*10 / 3);


            if (TimeOfAnimation < 2)
            {

                return RotateAndScaleImage(this.SourceImage, TimeOfAnimation  * 1080, (float)(0.5 * TimeOfAnimation));

            }
            else
            {
                EndAnimation = true;
                return RotateAndScaleImage(this.SourceImage, 0, 1);
                
            }
        }

        public override void MouseCLick()
        {
            throw new NotImplementedException();
        }
    }
}
