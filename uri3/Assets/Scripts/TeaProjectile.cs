using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaProjectile : MonoBehaviour
{
    public int damage = 1;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cup"))
        {
            Cup cup = collision.gameObject.GetComponent<Cup>();
            if (cup != null)
            {
                cup.TakeDamage(damage);
            }

            Destroy(gameObject);
        }
    }
}

