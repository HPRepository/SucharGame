using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SucharGame.GUI.Reactions
{
    public class RotateAndScale : ObjectReaction
    {

        private int DegreesPerSecond;
        private float ScaleFrom;
        private float ScaleTo;
        


        public RotateAndScale(GUIObject objectToChange, int degreesPerSecond, float scaleFrom, float scaleTo, float timeOfReaction) : base(objectToChange, timeOfReaction)
        {
            this.Name = "RotateAndScale";

            this.DegreesPerSecond = degreesPerSecond;
            this.ScaleFrom = scaleFrom;
            this.ScaleTo = scaleTo;
            



        }
        public override void Update(float dt)
        {
            Time += dt;

            float scale;

            if (ScaleFrom - ScaleTo < 0)
            {
                scale = ScaleFrom + (((ScaleTo - ScaleFrom) / TimeOfReaction)*Time);
            } else scale = ScaleFrom - (((ScaleFrom - ScaleTo) / TimeOfReaction)*Time);

           
            if (Time < TimeOfReaction)
            {

                ObjectToChange.StageImage = 
                    RotateAndScaleImage(ObjectToChange.SourceImage, -(Time * DegreesPerSecond), (float)((scale)));

            }
            else
            {
                if(!EndReaction)ObjectToChange.StageImage = RotateAndScaleImage(ObjectToChange.SourceImage, 0, (float)ScaleTo);
                this.EndReaction = true;
                this.Active = false;
            }
        }
        protected Image RotateAndScaleImage(Image img, float degrees, float scale)
        {


            Image tmpImage = ObjectToChange.MyBitmap;


            Graphics tmpGrContext = Graphics.FromImage(tmpImage);

            tmpGrContext.Clear(System.Drawing.Color.Transparent);

            tmpGrContext.TranslateTransform(tmpImage.Width / 2, tmpImage.Height / 2);

            tmpGrContext.RotateTransform(-degrees);

            tmpGrContext.DrawImage(img,

                new Rectangle((int)((-img.Width / 2) * scale), (int)((-img.Height / 2) * scale),

                (int)(img.Width * scale), (int)(img.Height * scale)),

                new Rectangle(0, 0, img.Width, img.Height),
                 GraphicsUnit.Pixel);

            tmpGrContext.RotateTransform(degrees);

            //tmpGrContext.TranslateTransform(-tmpImage.Width * frameScale / 2, -tmpImage.Height * frameScale);

            return tmpImage;

        }
    }
}
