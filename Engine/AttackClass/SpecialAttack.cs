using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.AttackClass
{
    public class SpecialAttack :Attack
    {
        public SpecialAttack()
        {
            base._NameOfAttack = "The Special Suprise";
        }

        public SpecialAttack(Players.Player player) : base(player) { }


        public override int AttackHP()
        {
            return NumberGenerator.GetInstance().GenerateValue(10, 15);
        }
    }
}
