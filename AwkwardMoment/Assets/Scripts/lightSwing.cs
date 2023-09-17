using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class lightSwing : MonoBehaviour
{
    public float endRotationX = 113f;
    public float cycleLength = 2f;
    // Start is called before the first frame update
    void Start()
    {
        transform.DORotate(new Vector3(endRotationX, -90, -90), cycleLength).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }


}
