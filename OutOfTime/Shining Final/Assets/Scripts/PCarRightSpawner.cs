using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PCarRightSpawner : MonoBehaviour
{
    public float moveSpeed = 5f;  // Adjust the speed as needed
    private bool moveRight = true;

    void Update()
    {
        // Move the object left and right
        if (moveRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }

        // Check if the object needs to change direction
        if (transform.position.x >= 5f)  // Adjust the threshold as needed
        {
            moveRight = false;
        }
        else if (transform.position.x <= -5f)  // Adjust the threshold as needed
        {
            moveRight = true;
        }
    }
}
