using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    public Transform posA;
    public Transform posB;

    public float speed = 300f;

    private int moveDirection = 1;

    public GameManager manager;
    void Update()
    {
        var step = speed * Time.deltaTime;

        if (moveDirection > 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, posA.position, step);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, posB.position, step);
        }

        if (transform.position == posA.position)
        {
            moveDirection = -1;

        }else if(transform.position == posB.position)
        {
            moveDirection = 1;
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag== "Player")
        {
            manager.GameOver();
        }
    }
}
