using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedActivation : MonoBehaviour
{
    public GameObject objectToDeactivate;
    public GameObject objectToActivate1; // Assign the object to activate in the Inspector
    public GameObject objectToActivate2;
    public GameObject objectToActivate3;
    public float activationDelay1 = 2.0f; // Set the activation delay in the Inspector
    public float activationDelay2 = 4.0f;
    public float activationDelay3 = 6.0f;

    private bool playerInsideTrigger = false;
    private float timer = 0.0f;

    private void Update()
    {
        if (playerInsideTrigger)
        {
            timer += Time.deltaTime;
            if (timer >= activationDelay1)
            {
                objectToActivate1.SetActive(true); // Activate the object after the delay
                objectToDeactivate.SetActive(false);

            }
            timer += Time.deltaTime;
            if (timer >= activationDelay2)
            {
                objectToActivate2.SetActive(true); // Activate the object after the delay
                objectToActivate1.SetActive(false);

            }
            timer += Time.deltaTime;
            if (timer >= activationDelay3)
            {
                objectToActivate3.SetActive(true); // Activate the object after the delay
                objectToActivate2.SetActive(false);

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Assuming the player has a "Player" tag
        {
            playerInsideTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Assuming the player has a "Player" tag
        {
            playerInsideTrigger = false;
            timer = 0.0f; // Reset the timer when the player exits the trigger
        }
    }
}
