using System;
using System.Collections.Generic;
using System.Text;

namespace SucharGame.AttackClass.ComboAttack
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
