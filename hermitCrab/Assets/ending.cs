using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class ending : MonoBehaviour
{
    //public GameObject crabShell;
    public GameObject endingPoem;
    public GameObject instrTxt;
    public GameObject endingTitle;
    public TMP_Text endingTitleTxt;
    void Start()
    {
        //crabShell.GetComponent<Rigidbody>().isKinematic = false;
        endingPoem.SetActive(true);
        instrTxt.SetActive(false);
        endingTitle.SetActive(true);
        StartCoroutine(waitShell());


    }

    IEnumerator waitShell()
    {
        yield return new WaitForSeconds(4f);
        endingTitleTxt.DOFade(1f, 7f).SetEase(Ease.InOutSine);
    }
}
