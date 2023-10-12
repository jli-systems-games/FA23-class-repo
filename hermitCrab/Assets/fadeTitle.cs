using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
public class fadeTitle : MonoBehaviour
{
    public TMP_Text titleTxt;

    void Start()
    {
        StartCoroutine(titleDelay());
        
    }

    IEnumerator titleDelay()
    {
        yield return new WaitForSeconds(7f);
        titleTxt.DOFade(1f, 5f).SetEase(Ease.OutSine);
    }

}
