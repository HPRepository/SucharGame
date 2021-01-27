using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.AttackClass.AttackAdminister.ComboAttackLists
{
    internal class ComboAttack
    {
        internal Type[] ComboSequence;
        internal Action AttackAction;

        internal ComboAttack(Action attackAction, params Type[] sequence)
        {
            this.ComboSequence = sequence;
            this.AttackAction = attackAction;
        }
    }
}
