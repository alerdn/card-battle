using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : SpellCard, ICard
{
    public override void Action()
    {
        Debug.Log($"Healing {Power} HP");
    }
}
