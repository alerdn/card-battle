using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CreatureCard : BaseCard, ICard, IAttacker
{
    [SerializeField]
    private int _currentHitPoints;

    public int MaxHitPoints;
    public int CurrentHitPoints
    {
        get => _currentHitPoints;
        set { _currentHitPoints = value; OnUpdate(); }
    }
    public int Attack;

    public event Action OnUpdate;

    public abstract void Action();
}
