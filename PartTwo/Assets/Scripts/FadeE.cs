using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class FadeE : MonoBehaviour
{
    public TMP_Text ins;
    private bool isPlayerInside = false;
    private bool hasChangedColor = false;
    public bool hasInteracted = false;
    public RawImage blackFade;
    public GameObject playerOne;
    public GameObject playerTwo;
    public GameObject prevScene;
    public GameObject nextScene;

    void Start()
    {
        if (ins != null)
        {
            ins.gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInside = true;
            if (!hasChangedColor)
            {
                if (ins != null)
                {
                    ins.gameObject.SetActive(true);
                    ins.DOFade(1f, 0.5f).SetEase(Ease.InOutSine);
                }
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInside = false;

            if (!isPlayerInside)
            {
                ins.DOFade(0.0f, 0.5f).SetEase(Ease.InOutSine);
            }
        }
    }

    void Update()
    {
        if (isPlayerInside && Input.GetKeyDown(KeyCode.E) && !hasChangedColor)
        {
            ChangeEmissionColor();
            hasChangedColor = true;

            if (hasChangedColor)
            {
                hasInteracted = true;
                if (hasInteracted)
                {
                    ins.DOFade(0.0f, 2f).SetEase(Ease.InOutSine).OnComplete(() => {
                        ins.gameObject.SetActive(false);
                    });
                }
            }
        }
    }

    void ChangeEmissionColor()
    {
        blackFade.DOFade(1f, 4f).SetEase(Ease.InOutSine).OnComplete(() =>
        {
            playerOne.SetActive(false);
            playerTwo.SetActive(true);
            StartCoroutine(waitChange());

            
        });

        IEnumerator waitChange()
        {
            nextScene.SetActive(true);

            yield return new WaitForSeconds(2f);
            blackFade.DOFade(0f, 4f).SetEase(Ease.InOutSine).OnComplete(() =>
            {
                prevScene.SetActive(false);
            });
        }
    }
}
