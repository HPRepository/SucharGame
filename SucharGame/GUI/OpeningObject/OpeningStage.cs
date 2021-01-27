using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;



namespace SucharGame.GUI.OpeningObject
{
    public class OpeningStage : GUIStage
    {
        public OpeningStage(int width, int height) : base(width, height)
        { }

        public override void Start()
        {
            
            this.AddObject(new TitleName());
            this.AddObject(new TwistLogo());

          ObjectToDisplay[1].Active = true;
            
        }

        public override void Update(float dt)
        {

            if (ObjectToDisplay[1].EndOfReaction == true)
            {
                ObjectToDisplay[0].Active = true;
            }



            base.Update(dt);
        }

    }
}
