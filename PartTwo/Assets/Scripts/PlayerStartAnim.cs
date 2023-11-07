using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class PlayerStartAnim : MonoBehaviour
{
    public Animator animator;
    public bool isTriggered = false;
    public GameObject goldOne;
    public GameObject leoOne;
    public GameObject upCan;
    public TMP_Text getUpTxt;
    public RawImage blackScreen;

    void Start()
    {
        blackScreen.DOFade(0f, 9f).SetEase(Ease.InOutSine);
        getUpTxt.DOFade(1f, 30f).SetEase(Ease.InOutSine);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isTriggered)
        {
            playSecond();
        }
    }

    void playSecond()
    {
        animator.SetTrigger("Up");
        isTriggered = true;
        StartCoroutine(waitUp());
        getUpTxt.DOFade(0f, 4f).SetEase(Ease.InOutSine).OnComplete(() =>
        {
            upCan.SetActive(false);
        });

        
    }

    IEnumerator waitUp()
    {
        yield return new WaitForSeconds(8f);
        goldOne.SetActive(true);
        leoOne.SetActive(false);
        //blackScreen.DOFade(1f, 3f).SetEase(Ease.InOutSine).OnComplete(() =>
        //{
        //    StartCoroutine(waitSwitch());
        //});
    }

    //IEnumerator waitSwitch()
    //{
    //    goldOne.SetActive(true);
    //    leoOne.SetActive(false);
    //    yield return new WaitForSeconds(2f);


    //    blackScreen.DOFade(0f, 10f).SetEase(Ease.InOutSine);
    //}
}
