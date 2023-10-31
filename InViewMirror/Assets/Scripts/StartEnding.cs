using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class StartEnding : MonoBehaviour
{
    [SerializeField] private bool triggerActive = false;

    public GameObject endingChar;
    public GameObject startingChar;
    public GameObject workingMirror;
    public GameObject brokenMirror;
    public TMP_Text insEnding;
    public RawImage black;
    public GameObject eva;
    public GameObject evaTxt;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = true;
            insEnding.DOFade(1f, 1f).SetEase(Ease.InOutSine);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = false;
            insEnding.DOFade(0f, 1f).SetEase(Ease.InOutSine);
        }
    }

    private void Update()
    {
        if (triggerActive && Input.GetKeyDown(KeyCode.E))
        {
            SomeCoolAction();
        }
    }
    public void SomeCoolAction()
    {

        StartCoroutine(endFade());

    }

    IEnumerator endFade()
    {
        black.DOFade(1f, 2f).SetEase(Ease.InOutSine);
        eva.SetActive(false);
        evaTxt.SetActive(false);
        yield return new WaitForSeconds(3.5f);
        insEnding.DOFade(0f, 0.1f).SetEase(Ease.InOutSine);
        black.DOFade(0f, 1f).SetEase(Ease.InOutSine);
        startingChar.SetActive(false);
        endingChar.SetActive(true);
        workingMirror.SetActive(true);
        brokenMirror.SetActive(false);

    }
}
