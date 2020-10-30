using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.AttackClass
{
    public class TemporaryAttack : Attack
    {
        public TemporaryAttack()
        {
            base._NameOfAttack = "The Eternity";
        }

        public TemporaryAttack(Players.Player player) : base(player) { }


        public override int AttackHP()
        {
            return NumberGenerator.GetInstance().GenerateValue(1, 3);
        }
    }
}
