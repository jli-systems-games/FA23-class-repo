using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    public AudioClip crash;
    private AudioSource audioSource;
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the colliding object has the "enemy" or "wall" tag
        if (collision.gameObject.CompareTag("enemy") || collision.gameObject.CompareTag("projectile"))
        {
            audioSource.PlayOneShot(crash);
            // Destroy the object this script is attached to
            Destroy(gameObject);
        }
    }
}
