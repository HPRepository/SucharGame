using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.AttackClass.ComboAttack
{
    public class BBBAttack : Attack
    {
        protected override void SetName()
        {
            _NameOfAttack = "Karol Strasburger";
        }
        protected override void AttackHP()
        {
            _AttackHPValue = NumberGenerator.GetInstance().GenerateValue(0, 30);
        }
    }
}
