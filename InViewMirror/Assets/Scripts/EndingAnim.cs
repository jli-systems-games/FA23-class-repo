using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class EndingAnim : MonoBehaviour
{

    public RawImage endScreen;
    public TMP_Text endText;
    public TMP_Text quitText;
    public TMP_Text restartText;

    public GameObject quitBtn;
    public GameObject restartBtn;

    void Start()
    {
        StartCoroutine(waitCheck()); 
    }

    IEnumerator waitCheck()
    {
        yield return new WaitForSeconds(25f);
        transform.DORotate(new Vector3(0.85f, -2.5f, -0.5f), 9f).SetEase(Ease.InOutSine);
        yield return new WaitForSeconds(12f);
        endScreen.DOFade(1f, 6f).SetEase(Ease.InOutSine);
        endText.DOFade(1f, 10f).SetEase(Ease.InOutSine);
        yield return new WaitForSeconds(6f);
        quitBtn.SetActive(true);
        restartBtn.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        quitText.DOFade(1f, 3f).SetEase(Ease.InOutSine);
        restartText.DOFade(1f, 3f).SetEase(Ease.InOutSine);
    }
}
