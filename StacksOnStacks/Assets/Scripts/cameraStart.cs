using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class cameraStart : MonoBehaviour
{
    public float endX = -2.135f;
    public float endY = 1.76f;
    public float endZ = -7.145f;

    public float endXR = 17.2f;
    public float endYR = -22.2f;

    [SerializeField] private float _cycles = 3;

    void Start()
    {
        transform.DOMove(new Vector3(endX, endY, endZ), _cycles).SetEase(Ease.InOutSine);
        transform.DORotate(new Vector3(endXR, endYR, 0), _cycles).SetEase(Ease.InOutSine);
    }

}
