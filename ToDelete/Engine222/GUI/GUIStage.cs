using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Engine.GUI
{
    public class GUIStage
    {
        Image BackFrame;
        Image BackGround;

        int Width;
        int Height;

        Graphics Painter;
        List<GUIObject> ObjectToDisplay = new List<GUIObject>();


        public GUIStage(int width, int height)
        { 
            this.Width = width;
            this.Height = height;
            BackFrame = new Bitmap(width, height);
            Painter = Graphics.FromImage(BackFrame);
        }
        public void AddObject(GUIObject newGUIObject)
        {
            ObjectToDisplay.Add(newGUIObject);

        }

        public void UpdateObject(float dt)
        {
            ObjectToDisplay.ForEach(x => x.Update(dt));
        }
        public void RenderObject()
        {
            ObjectToDisplay.ForEach(x => x.Render(Painter));
        }

        public void PasteToFrontBuffor(Graphics frontFrame)
        {
            frontFrame.DrawImage(BackFrame, 0, 0);

        }

        public void WyczyscBufor(Image tlo = null)
        {
            if (tlo == null) Painter.FillRectangle(Brushes.White,new System.Drawing.Rectangle(0, 0, Width, Height) );
            else Painter.DrawImageUnscaled(tlo, 0, 0);
        }
    }
