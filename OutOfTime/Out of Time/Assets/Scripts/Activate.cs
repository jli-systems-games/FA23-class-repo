using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public GameObject objectToActivate; // Assign the object to activate in the Inspector
    public GameObject objectToDeactivate;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Assuming the player has a "Player" tag
        {
            objectToActivate.SetActive(true); // Activate the object
            objectToDeactivate.SetActive(false);
        }
    }
}
