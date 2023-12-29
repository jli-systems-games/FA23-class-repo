using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walllllllllll : MonoBehaviour
{
    public float pushForce = 5f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall") && Input.GetKey(KeyCode.Space))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(-pushForce, pushForce), ForceMode2D.Impulse);
        }
    }
}
