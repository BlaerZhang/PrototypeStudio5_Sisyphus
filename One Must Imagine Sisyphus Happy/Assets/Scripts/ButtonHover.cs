using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    private SpriteRenderer boulderSpriteRenderer;

    void Start()
    {
        boulderSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        boulderSpriteRenderer.DOFade(0, 0.5f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        boulderSpriteRenderer.DOFade(1, 0.5f);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        
    }
}
