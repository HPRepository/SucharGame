using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SucharGame.GUI.Reactions
{
    public class MoveToOrigin : ObjectReaction
    {
        protected int FromOriginalX;
        protected int FromOriginalY;

        public MoveToOrigin(GUIObject objectToChange, int fromOriginalPosX, int fromOriginalPosY, float timeOfReaction) : base(objectToChange, timeOfReaction)
        {
            this.FromOriginalX = fromOriginalPosX;
            this.FromOriginalY = fromOriginalPosY;
            this.Name = "MoveToOrigin";

        }
        public override void Update(float dt)
        {

            Time += dt;

            if(Time<TimeOfReaction)
            {
                ObjectToChange.PosX = ObjectToChange.OriginalPosX +
                    (int)(this.FromOriginalX - ((this.FromOriginalX / TimeOfReaction) * Time));

                ObjectToChange.PosY = ObjectToChange.OriginalPosY +
                    (int)(this.FromOriginalY - ((this.FromOriginalY / TimeOfReaction) * Time));
            } else
            {
                ObjectToChange.PosX = ObjectToChange.OriginalPosX;
                ObjectToChange.PosY = ObjectToChange.OriginalPosY;

                this.EndReaction = true;
                this.Active = false;
            }


           
        }
    }
}
