
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class EndingTrigger : MonoBehaviour
{
    public GameObject endingCam;
    public GameObject thePlayer;

    public TMP_Text titleTxt;
    public RawImage blackScreen;

    public GameObject waypoint;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            endingCam.SetActive(true);
            thePlayer.SetActive(false);
            StartCoroutine(fadeTitle());
        }

        IEnumerator fadeTitle()
        {
            
            yield return new WaitForSeconds(20f);
            waypoint.SetActive(false);
            titleTxt.DOFade(1f, 6f).SetEase(Ease.InOutSine);
            blackScreen.DOFade(1f, 6f).SetEase(Ease.InOutSine);
        }
    }
}

