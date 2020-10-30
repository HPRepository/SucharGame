using Engine.AttackClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Players
{
    public class MikoszPlayer : Player 
    {
        public MikoszPlayer(Player enemyPlayer) : base("The Mikosz", "Money, money, money.") 
        {
            AttackName.Add(typeof(BasicAttack), "The Kosher Suchar");
            AttackName.Add(typeof(TemporaryAttack), "The Menorah");
            AttackName.Add(typeof(SpecialAttack), "The Calvary");

        }
    }
}
