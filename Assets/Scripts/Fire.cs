using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject objectToSpawn; // Prefab of the object to create
    public float spawnDistance = 5.0f; // Distance from the camera to spawn the object

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Calculate the spawn position based on the camera's forward direction
            Vector3 spawnPosition = Camera.main.transform.position + Camera.main.transform.forward * spawnDistance;

            // Create the object at the calculated position
            Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
        }
    }
}
