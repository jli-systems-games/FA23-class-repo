using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class throws : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform SpawnPosition;

    public void SpawnObject(Button btn)
    {
        btn.interactable = false;
        GameObject newObject = Instantiate(objectToSpawn, SpawnPosition.position, Quaternion.identity);

        newObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 20);

        newObject.GetComponent<controlller>().btn = btn;
    }
}
