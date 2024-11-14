using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : SpellEffect
{
    public override void ActivateEffect(int specialAmount = 0, ICharacter target = null)
    {
        new DealDamageCommand(TurnManager.Instance.whoseTurn.otherPlayer.PlayerID, -specialAmount, TurnManager.Instance.whoseTurn.otherPlayer.Health + specialAmount).AddToQueue();
        TurnManager.Instance.whoseTurn.otherPlayer.Health += specialAmount;
    }
}
