using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class cameraEnd : MonoBehaviour
{
    public float endX = -2.49f;
    public float endY = 1.36f;
    public float endZ = -6.55f;

    public float endXR = 23f;
    public float endYR = 27f;

    [SerializeField] private float _cycles = 2;

    void Start()
    {
        transform.DOMove(new Vector3(endX, endY, endZ), _cycles).SetEase(Ease.InOutSine);
        transform.DORotate(new Vector3(endXR, endYR, 0), _cycles).SetEase(Ease.InOutSine);
    }

}
