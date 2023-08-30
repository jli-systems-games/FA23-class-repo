using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    public Transform positionA, positionB;
    public float speed = 5f;

    private int _moveDirection = 1;

    public GameManager manager;

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime;

        if (_moveDirection > 0) //right
            transform.position = Vector3.MoveTowards(
                transform.position,
                positionB.position,
                step);
        else //left
            transform.position = Vector3.MoveTowards(
                transform.position,
                positionA.position,
                step);

        if (transform.position == positionA.position)
            _moveDirection = 1; //if at A, go right next
        else if (transform.position == positionB.position)
            _moveDirection = -1; //if at B, go left next
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
            manager.GameOver();
       
    }
}
