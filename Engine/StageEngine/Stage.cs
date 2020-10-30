using System;
using System.Collections.Generic;
using System.Text;
using Engine.AttackClass;
using Engine.Players;

namespace Engine.StageEngine
{
    public class Stage
    {
        private Player PlayerOne;
        private Player PlayerTwo;
        private int RoundIndexOfGame = 0;

     
        // co z tymczasowym atakiem na 3xTury??
        public void ChooseAttackStage(Attack regularAttackPlayerOne, Attack regularAttackPlayerTwo)
        {
            // jak ma dzialac combo, czy atak ma byc wylowywany z playera, czy zewnetrznej funkcji

            




        }

        public Stage(Player playerOne, Player playerTwo)
        {
            this.PlayerOne = playerOne;
            this.PlayerTwo = playerTwo;
        }


        public void AddingRegularAttack(Attack regularAttackPlayer, List<Attack> regularAttackPlayerList)
        {
            if(regularAttackPlayerList.Count >=3)
            {
                regularAttackPlayerList.RemoveAt(0);
                regularAttackPlayerList.Add(regularAttackPlayer);

            } else
            {
                regularAttackPlayerList.Add(regularAttackPlayer);
            }
        }

    }
}
