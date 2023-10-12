using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatAnimDelay : MonoBehaviour
{
    public Animation legacyAnimation; // Reference to the Animation component
    public string animationClipName;  // Name of the legacy animation clip
    public float delayTime = 2.0f;     // The delay time in seconds before the animation loops again
    private bool isPlaying = true;    // Flag to track if the animation is playing

    private float lastAnimationTime = 0f; // Variable to store the last time the animation played

    void Update()
    {
        if (!isPlaying)
        {
            if (Time.time - lastAnimationTime >= delayTime)
            {
                legacyAnimation.Play(animationClipName);
                isPlaying = true;
                lastAnimationTime = Time.time;
            }
        }
    }

}
