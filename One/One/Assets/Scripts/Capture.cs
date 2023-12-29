using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capture : MonoBehaviour
{
    public bool thug;
    public GameObject platformPrefab;
    // Start is called before the first frame update
    void Start()
    {
        thug = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            if (thug == true)
            {
                SpawnPlatforms();
            }

            if (thug == false)
            {
                StorePlatforms();
            }
        }
    }

    List<GameObject> storedPlatforms = new List<GameObject>();
    

    private void SpawnPlatforms()
    {
        foreach (GameObject platform in storedPlatforms)
        {
            Vector3 adjustedPos = new Vector3(platform.transform.position.x, platform.transform.position.y + gameObject.transform.position.y, 0f);
            Instantiate(platformPrefab, adjustedPos, Quaternion.identity);
        }
        storedPlatforms.Clear();

        thug = false;
    }

    private void StorePlatforms()
    {
        GameObject[] tempArray = GameObject.FindGameObjectsWithTag("Platform");

        foreach(GameObject platform in tempArray)
        {
            storedPlatforms.Add(platform);
        }

        thug = true;
    }
}
