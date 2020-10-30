using Engine.AttackClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Players
{
    public abstract class Player : INameOfAttacks, IAttackList
    {
        public readonly string PlayerName;
        public readonly string PlayerDescription;
        private int HealthPoint = 100;
        public int PointOfLastAttack
        {
            get; private set;
        }
        public List<List<Attack>> TimelineOfEnemyAttacks { get; set; }
        public List<Attack> RegularAttackOfPlayer { get; set; }

        protected Dictionary<Type, string> AttackName;
       
        protected Player (string playerName, string playerDescription)
        {
            this.PlayerName = playerName;
            this.PlayerDescription = playerDescription;
            
        }


        public virtual void HPReduction(int attackValue)
        {
            HealthPoint -= attackValue;
            PointOfLastAttack = attackValue;
            
        }

        public string GetNameOfAttack(Attack attack)
        {
            return AttackName.ContainsKey(attack.GetType()) ? AttackName[attack.GetType()] : attack.NameOfAttack;
        }
    }
}
