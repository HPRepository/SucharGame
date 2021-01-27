using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.AttackClass.ComboAttack
{
   public  class BBTAttack :Attack
    {
        protected override void SetName()
        {
            _NameOfAttack = "Medic!";
        }
        protected override void AttackHP()
        {
            _AttackHPValue = -NumberGenerator.GetInstance().GenerateValue(5, 15);
        }
    }
}
