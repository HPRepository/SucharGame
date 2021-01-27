using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using SucharGame.AttackClass;
using SucharGame.AttackClass.AttackAdminister;
using SucharGame.Players;

namespace SucharGame.StageEngine
{
    public class Stage
    {
        private Player PlayerOne;
        private Player PlayerTwo;
        RoundIndexOfGame MyRoundIndexOfGame;

        AttackAdminister AttackAdministerPlayerOne;
        AttackAdminister AttackAdministerPlayerTwo;

        
        public Stage(Player playerOne, Player playerTwo)
        {
            this.PlayerOne = playerOne;
            this.PlayerTwo = playerTwo;
            this.MyRoundIndexOfGame = new RoundIndexOfGame();

            AttackAdministerPlayerOne = playerOne.InitializationAttackAdminister(playerTwo, MyRoundIndexOfGame);
            AttackAdministerPlayerTwo = playerTwo.InitializationAttackAdminister(playerOne, MyRoundIndexOfGame);
            
        }

        


    }
}
