using System;
using System.Collections.Generic;
using System.Text;

namespace SucharGame.AttackClass
{
    public abstract class Attack : IAttackDescription
    {
        protected string _NameOfAttack;
        protected int _AttackHPValue;

        public Attack()
        {
            SetName();
            AttackHP();
        }
        public int AttackHPValue
        {
            get => _AttackHPValue;
        }
        public string NameOfAttack
        {
            get => _NameOfAttack;

        }
        protected abstract void SetName();
        protected abstract void AttackHP();


        
    }
}
