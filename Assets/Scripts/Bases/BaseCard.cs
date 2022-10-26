using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType
{
    Spell,
    Creature,
    Mana
}

public abstract class BaseCard : MonoBehaviour
{
    public CardType Type;
    public string Name;
    public int Cost;
    public string Description;
}
