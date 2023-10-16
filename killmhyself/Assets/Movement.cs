using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject cube;
    private Rigidbody2D rb;

    void Start()
    {
        rb = cube.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right*10f); 
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
}
