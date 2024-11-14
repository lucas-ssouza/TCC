using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkUp : SpellEffect
{


    public override void ActivateEffect(int specialAmount = 0, ICharacter target = null)
    {
        //new DealDamageCommand(target.ID, specialAmount, healthAfter: target.Attack + specialAmount).AddToQueue();
        target.Attack += specialAmount;
    }
}
