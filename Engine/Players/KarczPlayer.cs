using System;
using System.Collections.Generic;
using System.Text;
using Engine.AttackClass;

namespace Engine.Players
{
    public class KarczPlayer : Player
    {
        public KarczPlayer(Player enemyPlayer) : base("The Karcz", "The very big Fat Boy. He eats his enemy piece bye piece.") 
        {
            AttackName.Add(typeof(BasicAttack), "The Greasy Suchar");
            AttackName.Add(typeof(TemporaryAttack), "The Motherf*ckerburger");
            AttackName.Add(typeof(SpecialAttack), "The Greed");
        }
    }
}
