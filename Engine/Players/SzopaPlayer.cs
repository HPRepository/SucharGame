using System;
using System.Collections.Generic;
using System.Text;
using Engine.AttackClass;

namespace Engine.Players
{
   public class SzopaPlayer :Player
    {

        public SzopaPlayer(Player enemyPlayer) : base("The Szopa", "Nobody knows who she is. " +
            "Rumors say that she is from Sosnowiec. Are you scared now?") 
        {

            AttackName.Add(typeof(BasicAttack), "The Mistery Suchar");
            AttackName.Add(typeof(TemporaryAttack), "The Period");
            AttackName.Add(typeof(SpecialAttack), "The Delicious Breakfast");
        }


    }
}
