using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SucharGame.GUI.Reactions
{
    public class Sound : ObjectReaction
    {
        

        public Sound(GUIObject objectToChange,string fileName, float timeOfReaction=0) :base(objectToChange, timeOfReaction)
        {
            objectToChange.MyMediaPlayer.Open(new System.Uri(System.IO.Directory.GetCurrentDirectory() + "\\" + fileName));
            
        }
        public override void Update(float dt)
        {
            Time += dt;
            if (Time < TimeOfReaction) ObjectToChange.MyMediaPlayer.Play();
            else
            {
                ObjectToChange.MyMediaPlayer.Stop();
                this.EndReaction = true;
                this.Active = false;
            }
        }
    }
}
