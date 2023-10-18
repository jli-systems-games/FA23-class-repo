using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;

    void Start()
    {
        cam2.enabled = false;
        cam1.enabled = true;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        cam1.enabled = false;
        cam2.enabled = true;
    }
}
