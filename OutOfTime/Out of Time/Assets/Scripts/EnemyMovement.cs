using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float movementSpeed = 5.0f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D component not found on the object.");
        }
    }

    private void Update()
    {
        if (rb != null)
        {
            Vector2 leftMovement = new Vector2(-movementSpeed, 0);
            rb.velocity = leftMovement;
        }
    }
}
