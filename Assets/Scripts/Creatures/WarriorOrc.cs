using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorOrc : CreatureCard, ICard
{
    public override void Action()
    {
        GameManager.Instance.AttackTarget(this);
    }
}
