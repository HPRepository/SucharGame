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

        public int Width { get; set; }
        public int Height { get; set; }

        public bool DeleteMe { get; set; }
        public bool EndAnimation { get; set; }
        public bool Active { get; set; }
        public float TimeOfAnimation;


        protected Image SourceImage { get; set; }
        protected Image StageImage {get; set; }
        

      
        public GUIObject(Image img,int posX, int posY, int width, int height) // X,Y center of object
        {
            this.SourceImage = img;
            this.PosX = posX;
            this.PosY = posY;
            this.Width = width;
            this.Height = height;
            this.DeleteMe = false;
            this.EndAnimation = false;
            this.TimeOfAnimation = 0;
            this.Active = false;


        }

        

        public void Update(float dt)
        {
            TimeOfAnimation += dt;
            StageImage = this.GetImage();

        }
        public void Render(Graphics backFrame)
        {
            backFrame.DrawImage(StageImage, PosX-(StageImage.Width/2), PosY-(StageImage.Height/2));
        }

        public abstract void MouseCLick();


        public abstract Image GetImage(); 
        
        protected void MoveImage(int fromX,int fromY,int toX,int toY, float moveTime, float dt)
        {

        }
        protected Image RotateAndScaleImage(Image img, float degrees, float scale, float frameScale=1.2f)
        {
            

            Image tmpImage = new Bitmap((int)(this.Width*frameScale), (int)(this.Height* frameScale));

            Graphics tmpGrContext = Graphics.FromImage(tmpImage);

            tmpGrContext.TranslateTransform(tmpImage.Width/2, tmpImage.Height/2);

            tmpGrContext.RotateTransform(-degrees);

            tmpGrContext.DrawImage(img, 

                new Rectangle((int)((-img.Width / 2)*scale), (int)((-img.Height / 2)*scale), 

                (int)(img.Width * scale), (int)(img.Height * scale)), 

                new Rectangle(0, 0, img.Width, img.Height),
                 GraphicsUnit.Pixel);
            
            tmpGrContext.RotateTransform(degrees);

        tmpGrContext.TranslateTransform(-tmpImage.Width * frameScale / 2, -tmpImage.Height * frameScale);

            return tmpImage;

        }

     
        
        


    }
}
