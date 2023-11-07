using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using DG.Tweening;

public class CameraFOVTween : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera;
    public float targetFOV = 4f; 
    public float duration = 55f; 

    private void Start()
    {
        if (virtualCamera == null)
        {
            Debug.LogError("Virtual Camera is not assigned. Please assign a virtual camera in the Inspector.");
            return;
        }

        
        var sequence = DOTween.Sequence();
        var originalFOV = virtualCamera.m_Lens.FieldOfView;

        sequence.Append(DOTween.To(() => originalFOV, x => virtualCamera.m_Lens.FieldOfView = x, targetFOV, duration))
            .SetEase(Ease.InOutSine) 
            .OnComplete(() => Debug.Log("FOV animation completed.")); 
    }
}

