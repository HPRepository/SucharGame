using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace SucharGame.GUI
{
    public abstract class GUIStage
    {
        Image BackFrame;
        Image BackGround;

        protected int Width;
        protected int Height;

        Graphics Painter;
        protected List<GUIObject> ObjectToDisplay = new List<GUIObject>();


        public GUIStage(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            BackFrame = new Bitmap(width, height);
            Painter = Graphics.FromImage(BackFrame);
        }
        public abstract void Start();

        public void AddObject(GUIObject newGUIObject)
        {
            ObjectToDisplay.Add(newGUIObject);

        }

        public virtual void Update(float dt)
        {
            foreach(GUIObject x in ObjectToDisplay)
            {
                if (!x.EndOfReaction && x.Active) x.Update(dt);
            }
        }
        public void Render()
        {
            
            foreach (GUIObject x in ObjectToDisplay)
            {
                if (x.Active) x.Render(Painter);
            }
            
        }

        public void PasteToFrontBuffor(Graphics frontFrame, Rectangle FrontFrameRectangle)
        {
            frontFrame.DrawImage(BackFrame, FrontFrameRectangle, new Rectangle(0,0, Width, Height),  GraphicsUnit.Pixel);
        }

        public void ClearBackFrame(Image backGround = null)
        {
            if (backGround == null) Painter.FillRectangle(Brushes.White, new System.Drawing.Rectangle(0, 0, Width, Height));
            else Painter.DrawImage(backGround, 0, 0, this.Width, this.Height);
        }
    }
}
