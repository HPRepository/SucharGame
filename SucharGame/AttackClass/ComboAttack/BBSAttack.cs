using System;
using System.Collections.Generic;
using System.Text;

namespace SucharGame.AttackClass.ComboAttack
{
    public class BBSAttack :Attack
    {
        protected override void SetName()
        {
            _NameOfAttack = "The Suchar Master";
        }
        protected override void AttackHP()
        {
            _AttackHPValue = 25;
        }
    }
}
