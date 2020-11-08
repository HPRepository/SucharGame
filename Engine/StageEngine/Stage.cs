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
        RoundIndexOfGame MyRoundIndexOfGame;


        // co z tymczasowym atakiem na 3xTury??
        public void AddingAttackStage(Attack regularAttackPlayerOne, Attack regularAttackPlayerTwo)
        {
            // jak ma dzialac combo, czy atak ma byc wylowywany z playera, czy zewnetrznej funkcji



        }
        
        public Stage(Player playerOne, Player playerTwo)
        {
            this.PlayerOne = playerOne;
            this.PlayerTwo = playerTwo;
            this.MyRoundIndexOfGame = new RoundIndexOfGame();
        }

        public void AddingRegularAttack(Attack regularAttackPlayer, List<Attack> regularAttackPlayerList)
        {
            if (regularAttackPlayerList.Count >= 3)
            {
                regularAttackPlayerList.RemoveAt(0);
                regularAttackPlayerList.Add(regularAttackPlayer);

            }
            else
            {
                regularAttackPlayerList.Add(regularAttackPlayer);
            }
        }


    }
}
