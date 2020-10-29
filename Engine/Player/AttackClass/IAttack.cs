using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.StageEngine.AttackClass
{
    public interface IAttack
    {
        int AttackHP();
        string NameOfAttack { get;}

    }
}
