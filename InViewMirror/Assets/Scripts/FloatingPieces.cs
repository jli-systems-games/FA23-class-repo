using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingPieces : MonoBehaviour
{
    public float floatSpeed = 1f;
    public float rotationSpeed = 30f;

    void Start()
    {
        // Disable gravity for the shattered pieces.
        //GetComponent<Rigidbody>().useGravity = false;
    }

    void Update()
    {
        // Add a gentle upward force to simulate floating.
        GetComponent<Rigidbody>().AddForce(Vector3.up * floatSpeed, ForceMode.Acceleration);

        // Rotate the pieces for added realism.
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
