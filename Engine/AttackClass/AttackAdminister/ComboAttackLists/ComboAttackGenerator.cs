using System;
using System.Collections.Generic;
using System.Text;
using Engine.Players;
using Engine;
using Engine.AttackClass.RegularAttack.KarczuAttack;
using Engine.AttackClass.ComboAttack;

namespace Engine.AttackClass.AttackAdminister.ComboAttackLists
{
    public class ComboAttackGenerator
    {
        protected Player MainPlayer;
        protected Player PlayerAttacked;
        protected RoundIndexOfGame MyRoundIndexOfGame;
        List<ComboAttack> AttackList = new List<ComboAttack>();


        public ComboAttackGenerator(Player mainPlayer, Player playerAttacked, RoundIndexOfGame roundIndexOfGame)
        {
            this.MainPlayer = mainPlayer;
            this.PlayerAttacked = playerAttacked;
            MyRoundIndexOfGame = roundIndexOfGame;

            AttackList.Add(new ComboAttack(BBBAttack, typeof(BasicAttack), typeof(BasicAttack), typeof(BasicAttack)));
            AttackList.Add(new ComboAttack(TTSAttack, typeof(TemporaryAttack), typeof(TemporaryAttack), typeof(SpecialAttack)));
            AttackList.Add(new ComboAttack(BBSAttack, typeof(BasicAttack), typeof(BasicAttack), typeof(TemporaryAttack)));
            AttackList.Add(new ComboAttack(TSTAttack, typeof(TemporaryAttack), typeof(SpecialAttack), typeof(TemporaryAttack)));
            AttackList.Add(new ComboAttack(TTTAttack, typeof(TemporaryAttack), typeof(TemporaryAttack), typeof(TemporaryAttack)));
            AttackList.Add(new ComboAttack(BBTAttack, typeof(BasicAttack), typeof(BasicAttack), typeof(TemporaryAttack)));
          

        }

        public void FindCombo()
        {
            foreach (ComboAttack x in AttackList)
            {
                if (x.ComboSequence[0].IsAssignableFrom(MainPlayer.RegularAttackOfPlayer[0].GetType()) &&
                    x.ComboSequence[1].IsAssignableFrom(MainPlayer.RegularAttackOfPlayer[1].GetType()) &&
                    x.ComboSequence[2].IsAssignableFrom(MainPlayer.RegularAttackOfPlayer[2].GetType())) x.AttackAction();

                break;
            }
        }
        protected virtual void BBBAttack()
        {
            MainPlayer.AddEnemyAttack(new BBBAttack(), MyRoundIndexOfGame.Index);
        }

        protected virtual void TTSAttack()
        {
           for(int i=0;i<3;i++) MainPlayer.AddEnemyAttack(new TTSAttack(), MyRoundIndexOfGame.Index+i);

        }

        protected virtual void BBSAttack()
        {
            MainPlayer.AddEnemyAttack(new BBSAttack(), MyRoundIndexOfGame.Index);
        }

        protected virtual void TSTAttack()
        {
            for (int i = 0; i < 2; i++) MainPlayer.AddEnemyAttack(new TSTAttack(), MyRoundIndexOfGame.Index + i);
        }

        protected virtual void TTTAttack()
        {
            MainPlayer.AddAttackFirst(new TTTAttack(), MyRoundIndexOfGame.Index);

        }

        protected virtual void BBTAttack()
        {
            for (int i = 0; i < 2; i++) MainPlayer.AddAttackFirst(new TTTAttack(), MyRoundIndexOfGame.Index+i);

        }


    }
}
