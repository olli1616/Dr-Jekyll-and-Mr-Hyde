using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TweenAnimationScript : MonoBehaviour
{
    [SerializeField] private RectTransform rect;
    [SerializeField] private float duration = 1;
    [SerializeField] private Vector2 targetSize;
    private void Awake()
    {
        DOTween.Init();
    }
    public void GoToCenter()
    {
        rect.DOAnchorPos(new Vector2(0, 0), duration);
    }

    public void ChangeSize()
    {
        rect.DOSizeDelta(targetSize, duration);
    }
}
