using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Engine.GUI
{
    public abstract class GUIObject
    {
        public string Name { get; set;}

        public float PosX { get; set; }
        public float PosY { get; set; }

        public float Witdh { get; set; }
        public float High { get; set; }

        public bool DeleteMe { get; set; }
        public bool EndAnimation { get; set; }
        protected float TimeOfAnimation;


        protected Image SourceImage { get; set; }
        protected Image StageImage {get; set; }
        


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
        

        
        


    }
}
