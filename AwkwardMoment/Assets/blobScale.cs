using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class blobScale : MonoBehaviour
{
    public float scaleAmount = 32f;
    void Update()
    {
        transform.DOScale(scaleAmount, 3f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }
}
