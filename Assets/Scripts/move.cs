using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Transform positionA, positionB;
    public float speed = 5f;

    private int moveDirection = -1;
    void Update()
    {
        var step = speed*Time.deltaTime;

        if (moveDirection > 0)
            transform.position = Vector3.MoveTowards(transform.position, positionB.position, step);
        else
            transform.position = Vector3.MoveTowards(transform.position, positionA.position, step);

        if (transform.position == positionA.position)
            moveDirection = 1;
        else if (transform.position == positionB.position)
            moveDirection = -1;
    }
}
