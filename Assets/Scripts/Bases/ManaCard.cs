using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ManaCard : BaseCard, ICard
{
    public int Amount;

    public abstract void Action();
}
