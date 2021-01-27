using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Media;


namespace SucharGame.GUI
{
    public abstract class GUIObject
    {
        public string Name { get; set;}

        public int PosX { get; set; }
        public int PosY { get; set; }
        public int OriginalPosX { get; set; }
        public int OriginalPosY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public bool DeleteMe { get; set; }
        public bool Active { get; set; }
        public bool EndOfReaction { get; set; }

        public float TimeOfObject;

        public MediaPlayer MyMediaPlayer = new MediaPlayer();

        public Image SourceImage { get; set; }
        public Image StageImage {get; set; }
        public Image MyBitmap { get; set; }


        public List<Reactions.ObjectReaction> ObjectReactions = new List<Reactions.ObjectReaction>();


        public GUIObject(Image img,string name, int posX, int posY, int width, int height) // X,Y center of object
        {
            this.SourceImage = img;
            this.StageImage = img;
            this.Name = name;
            this.PosX = posX;
            this.PosY = posY;
            this.OriginalPosX = posX;
            this.OriginalPosY = posY;
            this.Width = width;
            this.Height = height;
            this.DeleteMe = false;
            this.EndOfReaction= false;
            this.TimeOfObject = 0;
            this.Active = false;
            float frameScale = 2f;
            MyBitmap = new Bitmap((int)(this.Width * frameScale), (int)(this.Height * frameScale));


        }

        

        public void Update(float dt)
        {

            TimeOfObject += dt;
            this.EndOfReaction = true;

            this.ChangeObject();


            foreach (Reactions.ObjectReaction x in ObjectReactions)
            {
                if (!x.EndReaction)
                {
                    this.EndOfReaction = false;
                }
            }

                foreach (Reactions.ObjectReaction x in ObjectReactions)
                {
                    if (x.Active && !x.EndReaction) x.Update(dt);
                }
        }
        public void Render(Graphics backFrame)
        {
            backFrame.DrawImage(StageImage, PosX-(StageImage.Width/2), PosY-(StageImage.Height/2));
        }

        public abstract void MouseCLick();


        public abstract void ChangeObject();
        
        protected void MoveImage(int fromX,int fromY,int toX,int toY, float moveTime, float dt)
        {

        }
        protected Image RotateAndScaleImage(Image img, float degrees, float scale)
        {


            Image tmpImage = MyBitmap; 
           

            Graphics tmpGrContext = Graphics.FromImage(tmpImage);

            tmpGrContext.Clear(System.Drawing.Color.Transparent);

            tmpGrContext.TranslateTransform(tmpImage.Width/2, tmpImage.Height/2);

            tmpGrContext.RotateTransform(-degrees);

            tmpGrContext.DrawImage(img, 

                new Rectangle((int)((-img.Width / 2)*scale), (int)((-img.Height / 2)*scale), 

                (int)(img.Width * scale), (int)(img.Height * scale)), 

                new Rectangle(0, 0, img.Width, img.Height),
                 GraphicsUnit.Pixel);
            
            tmpGrContext.RotateTransform(degrees);

        //tmpGrContext.TranslateTransform(-tmpImage.Width * frameScale / 2, -tmpImage.Height * frameScale);

            return tmpImage;

        }

     
        
        


    }
}
