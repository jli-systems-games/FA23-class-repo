using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform spawnPosition;

    public void SpawnObject(Button btn)
    {
        btn.interactable = false;
        GameObject newObject = Instantiate(objectToSpawn, spawnPosition.position, Quaternion.identity);

        newObject.GetComponent<Rigidbody>().velocity = new Vector3(200, 0, 0);

        newObject.GetComponent<ObjectController>().btn = btn;

    }
}
