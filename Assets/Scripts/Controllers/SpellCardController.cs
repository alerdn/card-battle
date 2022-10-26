using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpellCardController : BaseCardController
{
    public SpellCard SpellCard { get; protected set; }

    [SerializeField] private TMP_Text _powerText;

    private void Start()
    {
        SpellCard = (SpellCard)Card;
        _powerText.text = SpellCard.Power.ToString();
    }
}
