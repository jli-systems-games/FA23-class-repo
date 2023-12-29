using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public static FallingPlatform Instance = null;
    public GameObject platformPrefab;

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);
    }
    void Start()
    {
        Instantiate(platformPrefab, new Vector2(-3f, 0f), platformPrefab.transform.rotation);
        Instantiate(platformPrefab, new Vector2(0f, 0f), platformPrefab.transform.rotation);
        Instantiate(platformPrefab, new Vector2(3f, 0f), platformPrefab.transform.rotation);
    }
    IEnumerator spawnPlatform(Vector2 spawnPosition)
    {
        yield return new WaitForSeconds(2f);
        Instantiate(platformPrefab, spawnPosition, platformPrefab.transform.rotation);
    }
}