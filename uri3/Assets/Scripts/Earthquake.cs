using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earthquake : MonoBehaviour
{
    public float shakeIntensity = 0.1f;
    public float shakeDuration = 1.0f;
    public float shakeFrequency = 1.0f; // Adjustable shake frequency

    private Vector3 originalPosition;
    private float shakeTimer;

    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        if (shakeTimer > 0)
        {
            Vector3 randomShake = new Vector3(
                Random.insideUnitSphere.x * shakeIntensity,
                0, // Do not affect Y-axis
                Random.insideUnitSphere.z * shakeIntensity
            );

            transform.position = originalPosition + randomShake;

            shakeTimer -= Time.deltaTime;

            if (shakeTimer <= 0)
            {
                transform.position = originalPosition; // Reset to original position when shaking ends
            }
        }
    }

    public void StartShake()
    {
        shakeTimer = shakeDuration;

        // Adjust shake frequency
        InvokeRepeating("CustomShake", 0f, 1f / shakeFrequency);
    }

    private void CustomShake()
    {
        if (shakeTimer <= 0)
        {
            CancelInvoke("CustomShake");
            transform.position = originalPosition; // Ensure the position is reset if shaking ends
        }
    }
}
