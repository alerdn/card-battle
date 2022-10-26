using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Phase
{
    Chosing,
    Attacking
}

public class GameManager : Singleton<GameManager>
{
    public Phase phase;
    public CreatureCard Attacker;

    public void AttackTarget(CreatureCard attackerOrTarget)
    {
        if (Attacker == null)
        {
            Attacker = attackerOrTarget;
            phase = Phase.Attacking;
        }
        else
        {
            if (attackerOrTarget == Attacker) return;

            attackerOrTarget.CurrentHitPoints -= Attacker.Attack;
            Attacker = null;
            phase = Phase.Chosing;
        }
    }
}
