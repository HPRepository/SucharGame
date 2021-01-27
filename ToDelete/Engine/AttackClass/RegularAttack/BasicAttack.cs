using System;
using System.Collections.Generic;
using System.Text;
using Engine.Players;


namespace Engine.AttackClass
{
    public class BasicAttack : Attack
    {
        protected override void SetName()
        {
            _NameOfAttack = "The Suchar";
        }
        protected override void AttackHP()
        {
            _AttackHPValue = NumberGenerator.GetInstance().GenerateValue(3, 6);
        }

      
    }
}
