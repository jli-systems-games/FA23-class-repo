using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCube : MonoBehaviour
{
    public GameObject cube;
    public Rigidbody rb;
    public float maxSpeed = 400f;

    void Start()
    {
        rb = cube.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float y = Input.GetAxis ("Vertical");

		float x = Input.GetAxis ("Horizontal");

		//rb.angularVelocity =  x * maxRotation;

		rb.AddForce(transform.forward * y * maxSpeed);
    }
}
