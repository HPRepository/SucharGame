using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Engine.AttackClass;
using Engine.AttackClass.AttackAdminister;
using Engine.Players;

namespace Engine.StageEngine
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
