using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.AttackClass
{
    public class TemporaryAttack : Attack
    {
        protected override void SetName()
        {
            _NameOfAttack = "The Eternity";
        }
        protected override void AttackHP()
        {
            _AttackHPValue = NumberGenerator.GetInstance().GenerateValue(1, 3);
        }

    }
}
