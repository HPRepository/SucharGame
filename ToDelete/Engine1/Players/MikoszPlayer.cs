﻿using Engine.AttackClass;
using Engine.AttackClass.RegularAttack.MikoszAttack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Players
{
    public class MikoszPlayer : Player 
    {
        public MikoszPlayer() 
            : base("The Mikosz", "Money, money, money.") { }

        public override Attack BasicAttack()
        {
            return new BasicAttackMikosz();
        }

        public override Attack SpecialAttack()
        {
            return new SpecialAttackMikosz();
        }

        public override Attack TemporaryAttack()
        {
            return new TemporaryAttackMikosz();
        }
    }
}
