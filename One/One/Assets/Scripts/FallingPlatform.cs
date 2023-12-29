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

        GameObject[] tempArray = GameObject.FindGameObjectsWithTag("Platform");

    }
    IEnumerator spawnPlatform(Vector2 spawnPosition)
    {
        yield return new WaitForSeconds(2f);
        Instantiate(platformPrefab, spawnPosition, platformPrefab.transform.rotation);
    }
}
//on key press, capture transform of things tagged "Platform"
//platform has spawnzone that sets it active when the camera is touching it, then sets in inactive when it's no longer touching
//on same key press, put out stored platforms, and take the transforms, but add player's y (add it to each platform Y) (gameObject.transform.position.Y = y/Player.GameObject.transform.position.Y)
//make a list for transforms with a foreach to instantiate prefabs at those transforms


//List<Transform>storedPlatforms = new List<Transform>();
//storedPlatforms = FindGameObjectsWithTag("Platform")

//SpawnPlatforms()
//{
// foreach(GameObject platform in storedPlatforms)
// {
//   Vector3 adjustedPos = new Vector3(platform.transform.position.x, platform.transform.position.y + gameObject.transform.position.y, 0f);
//   Instantiate(platformPrefab, adjustedPos, Quaternion.identity);
// }
//}

//need a bool to check if platforms are spawning or storing
//if bool is true spawn, if not store

//if false, store all tagged positions

//FindGameObjectsWithTag("Platform")