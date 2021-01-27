using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.AttackClass
{
    public class SpecialAttack :Attack
    {
        protected override void SetName()
        {
            _NameOfAttack = "The Special Suprise";
        }
        protected override void AttackHP()
        {
            _AttackHPValue = NumberGenerator.GetInstance().GenerateValue(10, 15);
        }

    }
}
