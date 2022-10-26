using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreatureCardController : BaseCardController
{
    public CreatureCard CreatureCard { get; protected set; }

    [SerializeField] private TMP_Text _attackText;
    [SerializeField] private TMP_Text _hpText;

    private void Start()
    {
        CreatureCard = (CreatureCard)Card;        
        UpdateUI();

        CreatureCard.OnUpdate += UpdateUI;
    }

    private void OnDestroy()
    {
        CreatureCard.OnUpdate -= UpdateUI;
    }

    private void UpdateUI()
    {
        _attackText.text = CreatureCard.Attack.ToString();
        _hpText.text = $"{CreatureCard.CurrentHitPoints}/{CreatureCard.MaxHitPoints}";
    }

    protected override void OnMouseEnter()
    {
        if (GameManager.Instance.phase == Phase.Attacking)
        {
            Debug.LogError($"Attack {CreatureCard.Name}!");
        }
        else
        {
            base.OnMouseEnter();
        }
    }
}
