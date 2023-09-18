using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class lightSwing : MonoBehaviour
{
    public float endRotationZ = 5f;
    public float cycleLength = 2f;
    public int loopAmount = -1;
    
    void Start()
    {
       
        transform.DORotate(new Vector3(0, 0, endRotationZ), cycleLength).SetEase(Ease.InOutSine).SetLoops(loopAmount, LoopType.Yoyo);
       
    }


}
