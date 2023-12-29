using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathClock : MonoBehaviour
{
    public GameObject objectToActivate;
    public float delayInSeconds = 60.0f;

    private float timer = 0.0f;
    private bool activated = false;
    public TextMeshProUGUI timerText;

    private void Update()
    {
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);

        // Update the TextMeshPro text to display the timer
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (!activated)
        {
            timer += Time.deltaTime;
            if (timer >= delayInSeconds)
            {
                // Activate the object
                objectToActivate.SetActive(true);
                activated = true;
            }
        }
    }
}
