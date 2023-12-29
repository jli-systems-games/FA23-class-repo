using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUP : MonoBehaviour
{
    public float initialSpeed = 5f;
    public float acceleration = 2f;

    private float currentSpeed;

    void Start()
    {
        currentSpeed = initialSpeed;
    }

    void Update()
    {
        transform.Translate(Vector3.up * currentSpeed * Time.deltaTime);
        currentSpeed += acceleration * Time.deltaTime;
    }
}
