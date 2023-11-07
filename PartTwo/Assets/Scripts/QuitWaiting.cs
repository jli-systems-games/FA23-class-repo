using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class QuitWaiting : MonoBehaviour
{
    public GameObject quitBtn;
    public TMP_Text quitTxt;

    void Start()
    {
        StartCoroutine(waitEnding());
    }

    IEnumerator waitEnding()
    {
        yield return new WaitForSeconds(70f);
        quitBtn.SetActive(true);
        quitTxt.DOFade(1f, 12f).SetEase(Ease.InOutSine);
    }


    void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
