using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class cameraStart : MonoBehaviour
{
    public float endX = -2.12f;
    public float endY = 1.52f;
    public float endZ = -7.21f;

    public float endXR = 15.26f;
    public float endYR = -13f;

    [SerializeField] private float _cycles = 3;

    void Start()
    {
        transform.DOMove(new Vector3(endX, endY, endZ), _cycles).SetEase(Ease.InOutSine);
        transform.DORotate(new Vector3(endXR, endYR, 0), _cycles).SetEase(Ease.InOutSine);
    }

}
