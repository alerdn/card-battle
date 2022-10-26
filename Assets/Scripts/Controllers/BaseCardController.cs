using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using DG.Tweening;

public class BaseCardController : MonoBehaviour
{
    public BaseCard Card { get; protected set; }

    [SerializeField] private TMP_Text _nameText;
    [SerializeField] private TMP_Text _descriptionText;
    [SerializeField] private TMP_Text _costText;

    private void Awake()
    {
        Card = GetComponent<BaseCard>();
        _nameText.text = Card.Name;
        _descriptionText.text = Card.Description;
        _costText.text = Card.Cost.ToString();
    }

    protected virtual void OnMouseDown()
    {
        Card.GetComponent<ICard>().Action();
    }

    protected virtual void OnMouseEnter()
    {
        transform.DOMoveY(-30f, .5f);
    }

    protected virtual void OnMouseExit()
    {
        transform.DOMoveY(-60f, .5f);
    }
}
