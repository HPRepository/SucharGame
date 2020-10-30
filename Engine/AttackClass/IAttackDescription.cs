using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.AttackClass
{
    public interface IAttackDescription
    {
        int AttackHP();
        string NameOfAttack { get;}

    }
}
