using System;
using System.Collections.Generic;
using System.Text;
using Engine.AttackClass;
using Engine.AttackClass.RegularAttack.SzopaAttack;

namespace Engine.Players
{
   public class SzopaPlayer :Player
    {

        public SzopaPlayer() 
            : base("The Szopa", "Nobody knows who she is. Rumors say that she is from Sosnowiec. Are you scared now?"){ }

        public override Attack BasicAttack()
        {
            return new BasicAttackSzopa();
        }

        public override Attack SpecialAttack()
        {
            return new SpecialAttackSzopa();
        }

        public override Attack TemporaryAttack()
        {
            return new TemporaryAttackSzopa();
        }
    }
}
