using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
public class EndingAnim : MonoBehaviour
{
    public GameObject thisCam;

    void Start()
    {
        thisCam.transform.DOMove(new Vector3(-9.16f, 0.34f, -312.4f), 2f).SetEase(Ease.InOutSine);
        thisCam.transform.DORotate(new Vector3(-37.7f, 174.3f, 0), 10f).SetEase(Ease.InOutSine).SetLoops(2);
        
        StartCoroutine(waitFall());
    }

    IEnumerator waitFall()
    {
        yield return new WaitForSeconds(16.3f);
        thisCam.transform.DORotate(new Vector3(-21.1f, 174.2f, 0), 1f).SetEase(Ease.InOutSine);


    }
}
