using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifeDuration = 2f;
    private float lifeTimer;
    public float speed = 8f;
    //public GameObject particleSpawn;
    // Use this for initialization
    void Start()
    {
        lifeTimer = lifeDuration;
    }
    // Update is called once per frame
    void Update()
    {
        // Make the bullet move.
        transform.position += transform.forward * speed * Time.deltaTime;
        // Check if the bullet should be destroyed.
        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //btn.interactable = true;

        //Instantiate(particleSpawn, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

