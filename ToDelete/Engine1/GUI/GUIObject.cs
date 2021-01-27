using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Engine.GUI
{
    public abstract class GUIObject
    {
        public string Name { get; set;}

        public int PosX { get; set; }
        public int PosY { get; set; }

        public int Witdh { get; set; }
        public int Height { get; set; }

        public bool DeleteMe { get; set; }
        public bool EndAnimation { get; set; }
        protected float TimeOfAnimation;


        protected Image SourceImage { get; set; }
        protected Image StageImage {get; set; }
        
        public GUIObject(Image img,int posX, int posY, int width, int height)
        {
            this.StageImage = img;
            this.PosX = posX;
            this.PosY = posY;
            this.Witdh = width;
            this.Height = height;
            this.DeleteMe = false;
            this.EndAnimation = true;
            this.TimeOfAnimation = 0;


        }

        public void Update(float dt)
        {
            StageImage = this.GetImage(dt);

        }
        public void Render(Graphics backFrame)
        {
            backFrame.DrawImage(StageImage, PosX, PosY);
        }

        public abstract void MouseCLick();


        protected abstract Image GetImage(float dt); 
        
        protected Image RotateImage(Image img, float degrees)
        {
            float radians = (float)((degrees%360) * Math.PI) / 180;

            Image tmpImage = new Bitmap(img.Width, img.Height);
            Graphics tmpGrContext = Graphics.FromImage(tmpImage);

            tmpGrContext.TranslateTransform(tmpImage.Width / 2, tmpImage.Height / 2);
            tmpGrContext.RotateTransform(-radians);
            tmpGrContext.DrawImage(img, -img.Width / 2, -img.Height / 2);
            tmpGrContext.TranslateTransform(-tmpImage.Width / 2, -tmpImage.Height / 2);

            return tmpImage;

        }
        
        


    }
}
