using System;
using System.Collections.Generic;
using System.Text;
using Engine.Players;
using Engine;
using Engine.AttackClass.AttackAdminister.ComboAttackLists;

namespace Engine.AttackClass.AttackAdminister
{
    public abstract class AttackAdminister
    {

        protected Player MainPlayer;
        protected Player PlayerAttacked;
        protected RoundIndexOfGame MyRoundIndexOfGame;
        protected ComboAttackGenerator MainPlayerComboAttackGenerator;
        public delegate void MainPlayerRegularAttack();
        public MainPlayerRegularAttack ChooseMainPlayerRegularAttack;


        public AttackAdminister(Player mainPlayer, Player playerAttacked, RoundIndexOfGame roundIndexOfGame, ComboAttackGenerator mainPlayerComboAttackGenerator)
        {
            this.MainPlayer = mainPlayer;
            this.PlayerAttacked = playerAttacked;
            MyRoundIndexOfGame = roundIndexOfGame;
            this.MainPlayerComboAttackGenerator = mainPlayerComboAttackGenerator;

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
            MainPlayerComboAttackGenerator.FindCombo();
        }


    }
}
