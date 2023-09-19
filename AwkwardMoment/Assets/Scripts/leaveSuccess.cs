using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class leaveSuccess : MonoBehaviour
{
    public float fadeDuration = 0.2f;
    public TMP_Text success;
    public AudioSource glitch;
    private void OnTriggerEnter(Collider other)
    {
        glitch.Play();
        success.DOFade(1f, fadeDuration).SetEase(Ease.InOutSine).SetLoops(-1,LoopType.Yoyo);

    }
}
