using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Cinemachine;
using TMPro;

public class StartCamera : MonoBehaviour
{
    public float endX = 1.34f;
    public float endY = 12f;
    public float endZ = -18.07f;

    public float endXR = 19.3f;
    public float endYR = -1.53f;
    public float endZR = -2.5f;

    [SerializeField] private float _cycles = 3;
    [SerializeField] private CinemachineVirtualCamera virtualCamera;

    public float targetFOV = 34.0f;
    public float transitionDuration = 3.0f;

    public TMP_Text infoOne;
    public TMP_Text infoTwo;
    public TMP_Text fight;
    public TMP_Text title;
    public GameObject startCanvas;

    void Start()
    {
        transform.DOMove(new Vector3(endX, endY, endZ), _cycles).SetEase(Ease.InOutSine);
        transform.DORotate(new Vector3(endXR, endYR, endZR), _cycles).SetEase(Ease.InOutSine);
        infoOne.DOFade(0f, _cycles).SetEase(Ease.OutSine);
        infoTwo.DOFade(0f, _cycles).SetEase(Ease.OutSine);
        fight.DOFade(0f, _cycles).SetEase(Ease.OutFlash);
        title.DOFade(0f, _cycles).SetEase(Ease.OutSine);
        StartCoroutine(ChangeFOVSmoothly());

    }

    IEnumerator ChangeFOVSmoothly()
    {
        float initialFOV = virtualCamera.m_Lens.FieldOfView;
        float startTime = Time.time;

        while (Time.time - startTime < transitionDuration)
        {
            float t = (Time.time - startTime) / transitionDuration;
            virtualCamera.m_Lens.FieldOfView = Mathf.Lerp(initialFOV, targetFOV, t);
            yield return null;
        }

        // Ensure the FOV is set to the exact target value when the transition ends
        virtualCamera.m_Lens.FieldOfView = targetFOV;
        startCanvas.SetActive(false);
    }
}
