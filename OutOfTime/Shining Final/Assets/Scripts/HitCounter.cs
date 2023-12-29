using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCounter : MonoBehaviour
{
    private int bulletCollisionCount = 0;
    public int bulletHealth = 1;
    private int clawCollisionCount = 0;
    public int clawHealth = 1;
    private int explosionCollisionCount = 0;
    public int explosionHealth = 1;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            bulletCollisionCount++;

            if (bulletCollisionCount >= bulletHealth)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("claw"))
        {
            clawCollisionCount++;

            if (clawCollisionCount >= clawHealth)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("explosion"))
        {
            explosionCollisionCount++;

            if (explosionCollisionCount >= explosionHealth)
            {
                Destroy(gameObject);
            }
        }
    }
}
