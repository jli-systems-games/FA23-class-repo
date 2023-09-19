using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class endingAnim : MonoBehaviour
{
    public TMP_Text story;

    public Image black;

    public Image cheese;

    public AudioSource sus;

    public GameObject restart;

    public GameObject blackScreen;

    void Start()
    {
        black.DOFade(0f, 5f).SetEase(Ease.InOutSine);
        StartCoroutine(storytime());

    }

    IEnumerator storytime()
    {
        yield return new WaitForSeconds(4f);
        story.DOFade(1f, 3f).SetEase(Ease.InOutSine);
        StartCoroutine(cheesetime());
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    IEnumerator cheesetime()
    {
        yield return new WaitForSeconds(12f);
        cheese.DOFade(1f, 3f).SetEase(Ease.InOutSine);
        sus.Play();
        blackScreen.SetActive(false);
        StartCoroutine(restarttime());
    }

    IEnumerator restarttime()
    {
        yield return new WaitForSeconds(6f);
        restart.SetActive(true);
    }
}
