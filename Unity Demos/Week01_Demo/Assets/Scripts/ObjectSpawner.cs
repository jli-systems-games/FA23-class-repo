using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform spawnPostion;
    public float bulletSpeed = 1.0f;

    public void SpawnObject(Button btn)
    {

        btn.interactable = false;
        GameObject newObject = Instantiate(objectToSpawn,
            spawnPostion.position, 
            Quaternion.identity);

        newObject.GetComponent<Rigidbody>().velocity = 
            new Vector3(0, 0, bulletSpeed);

        newObject.GetComponent<ObjectController>().btn = btn;
    }
}
