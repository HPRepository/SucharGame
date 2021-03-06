﻿using System;
using System.Collections.Generic;
using System.Text;
using SucharGame.Players;
using SucharGame;
using SucharGame.AttackClass.AttackAdminister.ComboAttackLists;

namespace SucharGame.AttackClass.AttackAdminister
{
    public class AttackAdminister
    {

        protected Player MainPlayer;
        protected Player PlayerAttacked;
        protected RoundIndexOfGame MyRoundIndexOfGame;
        protected ComboAttackGenerator MainPlayerComboAttackGenerator;
        public delegate void MainPlayerRegularAttack();
        public MainPlayerRegularAttack ChooseMainPlayerRegularAttack;


        public AttackAdminister(Player mainPlayer, Player playerAttacked, RoundIndexOfGame roundIndexOfGame)
        {
            this.MainPlayer = mainPlayer;
            this.PlayerAttacked = playerAttacked;
            MyRoundIndexOfGame = roundIndexOfGame;
            this.MainPlayerComboAttackGenerator = MainPlayer.GetComboAttackGenerator(PlayerAttacked, MyRoundIndexOfGame);
                

        }

        public void AttackSequence(MainPlayerRegularAttack mainPlayerRegularAttack)
        {
            mainPlayerRegularAttack();
            AddComboAttack();
        }


        public virtual void AddBasicAttack()
        {
            AddRegularAttack(MainPlayer.BasicAttack());
        }

        public virtual void AddTemporaryAttack()
        {
            AddRegularAttack(MainPlayer.TemporaryAttack(), 3); 
        }

        public virtual void AddSpecialAttack ()
        {
            AddRegularAttack(MainPlayer.SpecialAttack());
        }
    
        protected void AddRegularAttack(Attack regularAttack)
        {
            MainPlayer.AddRegularAttack(regularAttack);
            PlayerAttacked.AddEnemyAttack(regularAttack, MyRoundIndexOfGame.Index);
        }
        protected void AddRegularAttack(Attack regularAttack, int howMany)
        {
            MainPlayer.AddRegularAttack(regularAttack);

            for(int i=0;i<howMany;i++) PlayerAttacked.AddEnemyAttack(regularAttack, MyRoundIndexOfGame.Index+i);
        }
       protected void AddComboAttack()
        {
            if (MainPlayerComboAttackGenerator.FindCombo()) MainPlayer.RemoveRegularAttack();
        }


    }
}
