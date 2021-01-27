using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SucharGame.GUI.Reactions
{
    public abstract class ObjectReaction 
    {
        protected GUIObject ObjectToChange;

        protected float Time;
        public bool DeleteMe;
        public bool EndReaction;
        public string Name;
        public bool Active;

        protected float TimeOfReaction;


        public ObjectReaction(GUIObject objectToChange, float timeOfReaction)
        {
            this.ObjectToChange = objectToChange;
            this.Time = 0;
            this.DeleteMe = false;
            this.EndReaction = false;
            this.Active = true;
            this.TimeOfReaction = timeOfReaction;
        }

        public abstract void  Update(float dt);







    }
}
