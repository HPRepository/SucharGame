using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.AttackClass.ComboAttack
{
    public class TTSAttack :Attack
    {
        protected override void SetName()
        {
            _NameOfAttack = "KABOOM?";
        }
        protected override void AttackHP()
        {
            _AttackHPValue = 10;
        }
    }
}
