using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotLimiter : MonoBehaviour
{
    private float lastPressTime;
    private int pressCount;
    public MonoBehaviour shootComponent;

    private void Start()
    {
        shootComponent.enabled = true;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (Time.time - lastPressTime <= 2f && pressCount < 4)
            {
                pressCount++;
                Debug.Log("X key pressed " + pressCount + " time(s).");
                StartCoroutine(EnableComponentAfterDelay());
            }
            /*else if (Time.time - lastPressTime > 2f)
            {
                pressCount = 1;
                Debug.Log("X key pressed 1 time.");
            }*/

            lastPressTime = Time.time;
        }
    }

    private IEnumerator EnableComponentAfterDelay()
    {
        shootComponent.enabled = false;
        yield return new WaitForSeconds(0.5f);
        shootComponent.enabled = true;
    }
}
