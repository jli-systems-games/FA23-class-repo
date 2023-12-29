using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpinBullet : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float minSpawnInterval = 4f;
    public float maxSpawnInterval = 7f;
    public float radius = 5f;
    public float speed = 2f;

    private float nextSpawnTime;

    private void Start()
    {
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
        nextSpawnTime = Time.time + Random.Range(minSpawnInterval, maxSpawnInterval);
    }

    private void SpawnObject()
    {
        float angle = Random.Range(0f, 360f);
        float x = Mathf.Cos(angle) * radius;
        float y = Mathf.Sin(angle) * radius;

        Vector3 spawnPosition = transform.position + new Vector3(x, -y, 0f);
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}
