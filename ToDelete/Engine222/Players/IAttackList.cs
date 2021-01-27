using System;
using System.Collections.Generic;
using System.Text;
using Engine.AttackClass;

namespace Engine.Players
{
    public interface IAttackList
    {
        List<List<Attack>> TimelineOfEnemyAttacks {get;}
        List<Attack> RegularAttackOfPlayer { get;}

    }
}
