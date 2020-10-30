using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Players
{
    public interface INameOfAttacks
    {
        string GetNameOfAttack(AttackClass.Attack attack);
    }
}
