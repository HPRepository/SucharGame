using Engine.AttackClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Players
{
    public abstract class Player : IAttackList
    {
        public readonly string PlayerName;
        public readonly string PlayerDescription;
        private int HealthPoint = 100;

        public List<List<Attack>> TimelineOfEnemyAttacks { get; set; }
        public List<Attack> RegularAttackOfPlayer { get; set; }


        public virtual void HPReduction(int attackValue)
        {
            HealthPoint -= attackValue;
            
        }

    }
}
