using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class triggerVin : MonoBehaviour
{
    public RawImage vin;
    float duration = 2f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            vin.DOFade(0.7f, duration).SetEase(Ease.InSine);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            vin.DOFade(0f, duration).SetEase(Ease.InSine);
        }
    }
}
