using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class fadeIn : MonoBehaviour
{
    public TMP_Text haiku;
    void Start()
    {
        StartCoroutine(waitTitleEnd());
        
    }


    IEnumerator waitTitleEnd()
    {
        yield return new WaitForSeconds(8f);
        haiku.DOFade(1f, 14f).SetEase(Ease.InOutSine);
    }
}
