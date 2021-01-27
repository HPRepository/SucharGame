using System;
using System.Collections.Generic;
using System.Text;

namespace SucharGame.AttackClass.ComboAttack
{
    public class TSTAttack :Attack
    {
        protected override void SetName()
        {
            _NameOfAttack = "Napalm";
        }
        protected override void AttackHP()
        {
            _AttackHPValue = NumberGenerator.GetInstance().GenerateValue(10, 20);
        }
    }
}
