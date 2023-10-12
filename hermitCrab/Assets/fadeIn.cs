using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class fadeIn : MonoBehaviour
{
    public TMP_Text haiku;
    void Start()
    {
        haiku.DOFade(1f, 7f).SetEase(Ease.InOutSine);
    }


    void Update()
    {
        
    }
}
