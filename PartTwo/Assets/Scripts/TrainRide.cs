using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TrainRide : MonoBehaviour
{
    public GameObject bedroom;
    public GameObject finalPlayer;
    public GameObject thisPlayer;
    public GameObject thisTrain;
    public RawImage blackFade;
    void Start()
    {
        StartCoroutine(waitRide());
    }

    IEnumerator waitRide()
    {
        yield return new WaitForSeconds(15f);

        blackFade.DOFade(1f, 4f).SetEase(Ease.InOutSine).OnComplete(() =>
        {
            StartCoroutine(waitTransfer());




        });

       
    }
    IEnumerator waitTransfer()
    {
        yield return new WaitForSeconds(2f);
        bedroom.SetActive(true);
        thisPlayer.SetActive(false);
        finalPlayer.SetActive(true);
        yield return new WaitForSeconds(2f);
        blackFade.DOFade(0f, 4f).SetEase(Ease.InOutSine);
        thisTrain.SetActive(false);
    }
}
