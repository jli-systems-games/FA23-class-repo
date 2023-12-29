using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    public GameObject objectToEnable;

    void Start()
    {
        // Invoke the EnableObject method after 5 seconds
        Invoke("EnableObject", 5f);
    }

    void EnableObject()
    {
        // Check if the object to enable is not null
        if (objectToEnable != null)
        {
            // Enable the object
            objectToEnable.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Damn.");
        }
    }
}
