using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.AttackClass
{
    public abstract class Attack : IAttackDescription
    {
        protected string _NameOfAttack;
        public string NameOfAttack
        {
            get => _NameOfAttack;

        }
        public Attack() { }
        public Attack(Players.Player player)
        {
            
            _NameOfAttack = player.GetNameOfAttack(this);

        }

       
        public abstract int AttackHP();
    }
}
