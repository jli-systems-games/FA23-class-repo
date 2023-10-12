using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
public class fadeInstructions : MonoBehaviour
{
    public TMP_Text eTxt;

    void Start()
    {
        StartCoroutine(waitTitle());
        
    }

    IEnumerator waitTitle()
    {
        yield return new WaitForSeconds(12f);
        eTxt.DOFade(0.7f, 7f).SetEase(Ease.OutSine).SetLoops(-1, LoopType.Yoyo);
    }

}
