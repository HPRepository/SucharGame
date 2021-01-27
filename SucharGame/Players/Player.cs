using SucharGame.AttackClass;
using SucharGame.AttackClass.AttackAdminister.ComboAttackLists;
using System;
using System.Collections.Generic;
using SucharGame.AttackClass.AttackAdminister;
using System.Text;
using System.Data;

namespace SucharGame.Players
{
    public abstract class Player : IAttackList, IPlayerDescription
    {
        protected string _PlayerName;
        protected string _PlayerDescription;

        public string PlayerName { get => _PlayerName; }
        public string PlayerDescription { get => _PlayerDescription; }

        private int HealthPoint = 100;

        private List<List<Attack>> _TimelineOfEnemyAttacks;
        public List<List<Attack>> TimelineOfEnemyAttacks { get;}

        private List<Attack> _RegularAttackOfPlayer;
        public List<Attack> RegularAttackOfPlayer { get; }


        public Player(string playerName, string playerDescription)
        {
            this._PlayerName = playerName;
            this._PlayerDescription = playerDescription;
            
            _RegularAttackOfPlayer = new List<Attack>();
            _TimelineOfEnemyAttacks = new List<List<Attack>>();
        }
        
        public virtual AttackAdminister InitializationAttackAdminister(Player playerAttacked, RoundIndexOfGame roundIndexOfGame)
        {
            
            return new AttackAdminister(this, playerAttacked, roundIndexOfGame);
        }
        internal virtual ComboAttackGenerator GetComboAttackGenerator(Player playerAttacked, RoundIndexOfGame roundIndexOfGame)
        {
            return new ComboAttackGenerator(this, playerAttacked, roundIndexOfGame);
        }
        public void AddRegularAttack(Attack regularAttack)
        {
            if (_RegularAttackOfPlayer.Count >= 3)
            {
                _RegularAttackOfPlayer.RemoveAt(0);
                _RegularAttackOfPlayer.Add(regularAttack);

            }
            else
            {
                _RegularAttackOfPlayer.Add(regularAttack);
            }
        }

        public void RemoveRegularAttack()
        {
            RegularAttackOfPlayer.Clear();
        }

        public void AddEnemyAttack(Attack enemyAttack, int roundIndex)
        {
            if(_TimelineOfEnemyAttacks.Count < roundIndex + 1)
            {
                for (int i = 0; i < roundIndex + 1; i++) _TimelineOfEnemyAttacks.Add(new List<Attack>());
            }

            _TimelineOfEnemyAttacks[roundIndex].Add(enemyAttack);
        }

        public void AddAttackFirst(Attack attack, int roundIndex)
        {
            if (_TimelineOfEnemyAttacks.Count < roundIndex + 1)
            {
                for (int i = 0; i < roundIndex + 1; i++) _TimelineOfEnemyAttacks.Add(new List<Attack>());
            }

            _TimelineOfEnemyAttacks[roundIndex].Insert(0, attack);

        }


        public abstract Attack BasicAttack();
        public abstract Attack SpecialAttack();
        public abstract Attack TemporaryAttack();


        public virtual void HPReduction(int attackValue)
        {
            HealthPoint -= attackValue;
            
        }

    }
}
