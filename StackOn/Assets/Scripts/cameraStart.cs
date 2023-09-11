using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class cameraStart : MonoBehaviour
{
    public float endX = 6.295f;
    public float endY = 3.5f;
    public float endZ = -4.55f;

    public float endXR = 31.265f;
    public float endYR = -15.449f;

    [SerializeField] private float _cycles = 3;

    void Start()
    {
        transform.DOMove(new Vector3(endX, endY, endZ), _cycles).SetEase(Ease.InOutSine);
        transform.DORotate(new Vector3(endXR, endYR, 0), _cycles).SetEase(Ease.InOutSine);
    }

}
