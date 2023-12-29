using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootLeft : MonoBehaviour
{
    public GameObject objectToSpawn; // The object to spawn
    public float spawnDelayMin = 3f; // Minimum spawn delay in seconds
    public float spawnDelayMax = 8f; // Maximum spawn delay in seconds
    public float moveSpeed = 6f; // Speed at which the object moves down

    private float nextSpawnTime;

    private void Start()
    {
        // Set the initial spawn time
        SetNextSpawnTime();
    }

    private void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnObject();
            SetNextSpawnTime();
        }
    }

    private void SetNextSpawnTime()
    {
        nextSpawnTime = Time.time + Random.Range(spawnDelayMin, spawnDelayMax);
    }

    private void SpawnObject()
    {
        GameObject newObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);

        Rigidbody2D rb = newObject.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = Vector2.left * moveSpeed;
        }
    }
}
