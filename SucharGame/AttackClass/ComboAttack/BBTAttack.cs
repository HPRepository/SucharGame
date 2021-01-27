using System;
using System.Collections.Generic;
using System.Text;

namespace SucharGame.AttackClass.ComboAttack
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
