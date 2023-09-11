using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class cameraEnd : MonoBehaviour
{
    public float endX = 5.83f;
    public float endY = 2.88f;
    public float endZ = -3.3f;

    public float endXR = 33.8f;
    public float endYR = 28.4f;

    [SerializeField] private float _cycles = 2;

    void Start()
    {
        transform.DOMove(new Vector3(endX, endY, endZ), _cycles).SetEase(Ease.InOutSine);
        transform.DORotate(new Vector3(endXR, endYR, 0), _cycles).SetEase(Ease.InOutSine);
    }

}
