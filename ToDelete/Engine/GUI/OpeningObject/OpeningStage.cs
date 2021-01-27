using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Engine.GUI.OpeningObject;


namespace Engine.GUI
{
    public class OpeningStage : GUIStage
    {
        public OpeningStage(int width, int height) : base(width, height)
        { }

        public override void Start()
        {
            
            this.AddObject(new TitleName(Image.FromFile(@"Image\logo_title.png"), 1280/2, 720/2, 1280, 720));


            this.AddObject(new TwistLogo(Image.FromFile(@"Image\single_logo.png"), 696, 333, 287, 305));

            ObjectToDisplay[1].Active = true;
            
        }

        public override void Update(float dt)
        {

           if(ObjectToDisplay[1].EndAnimation == true) ObjectToDisplay[0].Active = true;



            base.Update(dt);
        }

    }
}
