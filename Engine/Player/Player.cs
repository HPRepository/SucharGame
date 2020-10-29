using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Player
{
    public abstract class Player
    {
        public readonly string  PlayerName;
        public readonly string PlayerDescription;

        private int HealthPoint = 100;

        Player EnemyPlayer;

       
        protected Player (string playerName, string playerDescription, Player enemyPlayer)
        {
            this.PlayerName = playerName;
            this.PlayerDescription = playerDescription;
            this.EnemyPlayer = enemyPlayer;
        }


        public virtual bool HPReduction(int attackValue)
        {
            HealthPoint -= attackValue;

            return HealthPoint >= 0 ? true : false;
        }




    }
}
