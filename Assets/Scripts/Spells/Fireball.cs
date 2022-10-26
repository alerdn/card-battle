using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : SpellCard, ICard
{
    public override void Action()
    {
        Debug.Log($"Burning enemies with {Power} damage");
    }        
}
