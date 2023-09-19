using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunTriggers : MonoBehaviour
{
    public Animator gunAnimator;
    public string[] fireAnimationNames; // Names of the firing animations
    public float timeBetweenShots = 0.2f; // Time delay between shots
    private bool isFiring = false;
    private int currentFireAnimationIndex = 0;
    private float timeSinceLastShot = 0f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isFiring)
        {
            StartFiring();
        }

        if (isFiring)
        {
            timeSinceLastShot += Time.deltaTime;

            if (timeSinceLastShot >= timeBetweenShots)
            {
                timeSinceLastShot = 0f;
                PlayNextFireAnimation();
            }
        }
    }

    private void StartFiring()
    {
        isFiring = true;
        currentFireAnimationIndex = 0;
        PlayNextFireAnimation();
    }

    private void PlayNextFireAnimation()
    {
        if (currentFireAnimationIndex < fireAnimationNames.Length)
        {
            // Play the next firing animation
            gunAnimator.SetTrigger(fireAnimationNames[currentFireAnimationIndex]);
            currentFireAnimationIndex++;
        }
        else
        {
            // All firing animations played, return to idle state
            isFiring = false;
            gunAnimator.SetTrigger("Idle");
        }
    }
}
