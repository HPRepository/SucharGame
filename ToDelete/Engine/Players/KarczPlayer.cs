using System;
using System.Collections.Generic;
using System.Text;
using Engine.AttackClass;
using Engine.AttackClass.RegularAttack.KarczuAttack;

namespace Engine.Players
{
    public class KarczPlayer : Player
    {
        public KarczPlayer() 
            :  base("The Karcz", "The very big Fat Boy. He eats his enemy piece bye piece.")
        {
        }

        public override Attack BasicAttack()
        {
            return new BasicAttackKarcz();
        }

        public override Attack SpecialAttack()
        {
            return new SpecialAttackKarcz();
        }

        public override Attack TemporaryAttack()
        {
            return new TemporaryAttackKarcz();
        }
    }
}
