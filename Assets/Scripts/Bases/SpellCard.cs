using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class SpellCard : BaseCard, ICard
{
    public int Power;

    public abstract void Action();
}
