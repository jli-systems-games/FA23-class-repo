using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupShake : MonoBehaviour
{
    public Earthquake earthquake;

    void Start()
    {
        // Reference to the Earthquake script
        if (earthquake == null)
            earthquake = FindObjectOfType<Earthquake>();
    }

    void Update()
    {
        // Check for user input to pour tea
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Trigger the earthquake effect
            earthquake.StartShake();
        }
    }
}
