using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.AttackClass.ComboAttack
{
    public class TTTAttack :Attack
    {

        protected override void SetName()
        {
            _NameOfAttack = "Patience is a Virtue";
        }
        protected override void AttackHP()
        {
            _AttackHPValue = -15;
        }
    }
}
