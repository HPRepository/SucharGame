using System;
using System.Collections.Generic;
using System.Text;
using SucharGame.AttackClass;

namespace SucharGame.Players
{
    public interface IAttackList
    {
        List<List<Attack>> TimelineOfEnemyAttacks {get;}
        List<Attack> RegularAttackOfPlayer { get;}

    }
}
