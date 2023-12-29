using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastDamage : MonoBehaviour
{
    public int blastdamage = 3;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with an enemy
        if (collision.gameObject.CompareTag("enemy"))
        {
            // Get the Enemy script from the collided object
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();

            // Deal damage to the enemy
            if (enemy != null)
            {
                enemy.TakeDamage(blastdamage);
            }
        }
    }
}
