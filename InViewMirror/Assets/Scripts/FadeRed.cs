using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class FadeRed : MonoBehaviour
{
    public Color targetColor = Color.blue;
    public float tweenDuration = 1.0f;
    private Renderer[] childRenderers;

    private bool isPlayerInside = false;
    private bool hasChangedColor = false;
    public bool hasInteracted = false;

    public TMP_Text ins;

    void Start()
    {
        childRenderers = GetComponentsInChildren<Renderer>();

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
            //if (hasChangedColor)
            //{
            //    //hasChangedColor = false;
            //    hasInteracted = true;
            //}

            //if (ins != null)
            //{

            //}
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
                    ins.DOFade(0.0f, 0.5f).SetEase(Ease.InOutSine).OnComplete(() => {
                        ins.gameObject.SetActive(false);
                    });
                }
            }
        }
    }

    void ChangeEmissionColor()
    {
        foreach (Renderer renderer in childRenderers)
        {
            renderer.material.DOColor(targetColor, "_EmissionColor", tweenDuration).SetEase(Ease.InOutSine);
        }
    }
}