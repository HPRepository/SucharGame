using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.AttackClass
{
    public class BasicAttack : Attack
    {


        public BasicAttack()
        {
            base._NameOfAttack = "The Suchar";
        }

        public BasicAttack(Players.Player player) : base(player) { }


        public override int AttackHP()
        {
            return NumberGenerator.GetInstance().GenerateValue(3, 6);
        }
    }
}
