using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jscript : MonoBehaviour
{
    private int randomValue;
    public AudioSource soundClip1; // Assign your audio clip in the Inspector
    public AudioSource soundClip2;
    public AudioSource soundClip3;
    public AudioSource soundClipW;
    public AudioSource soundClipL;
    private AudioSource audioSource;
    private bool soundScheduled = false;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        randomValue = Random.Range(1, 4);
        //soundClipW.Play();
        // Ensure the AudioSource component is attached to the same GameObject
    }

    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.A))
        {
            randomValue = Random.Range(1, 4); // Generates a random value between 1 and 3
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            randomValue = Random.Range(1, 4);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            randomValue = Random.Range(1, 4);
        }*/

        if (randomValue == 1 && !soundScheduled)
        {
            StartCoroutine(PlaySoundAfterDelay(2.0f));
            soundScheduled = true;
        }
        else if (randomValue == 2 && !soundScheduled)
        {
            StartCoroutine(PlaySoundAfterDelay(2.0f));
            soundScheduled = true;
        }
        else if (randomValue == 3 && !soundScheduled)
        {
            StartCoroutine(PlaySoundAfterDelay(2.0f));
            soundScheduled = true;
        }

        if (randomValue == 1 && Input.GetKeyDown(KeyCode.A))
        {
                //audioSource.PlayOneShot(soundClipW);
                soundClipW.Play();
                randomValue = Random.Range(1, 4);
                Debug.Log("Right A");
                soundScheduled = false;
        }
        else if (randomValue == 2 && Input.GetKeyDown(KeyCode.S))
        {
                //audioSource.PlayOneShot(soundClipW);
                soundClipW.Play();
                randomValue = Random.Range(1, 4);
                Debug.Log("Right S");
                soundScheduled = false;
        }
        else if (randomValue == 3 && Input.GetKeyDown(KeyCode.D))
        {
                //audioSource.PlayOneShot(soundClipW);
                soundClipW.Play();
                randomValue = Random.Range(1, 4);
                Debug.Log("Right D");
                soundScheduled = false;
        }

        else if (randomValue != 1 && Input.GetKeyDown(KeyCode.A))
        {
                //audioSource.PlayOneShot(soundClipL);
                soundClipL.Play();
                randomValue = Random.Range(1, 4);
                Debug.Log("Wrong A");
                soundScheduled = false;
        }
        else if (randomValue != 2 && Input.GetKeyDown(KeyCode.S))
        {
                //audioSource.PlayOneShot(soundClipL);
                soundClipL.Play();
                randomValue = Random.Range(1, 4);
                Debug.Log("Wrong S");
                soundScheduled = false;
        }
        else if (randomValue != 3 && Input.GetKeyDown(KeyCode.D))
        {
                //audioSource.PlayOneShot(soundClipL);
                soundClipL.Play();
                randomValue = Random.Range(1, 4);
                Debug.Log("Wrong D");
                soundScheduled = false;
        }
    }
    IEnumerator PlaySoundAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (randomValue == 1)
        {
                //audioSource.PlayOneShot(soundClip1);
                soundClip1.Play();
                Debug.Log("Press A");
        }
        else if (randomValue == 2)
        {
                //audioSource.PlayOneShot(soundClip2);
                soundClip2.Play();
                Debug.Log("Press S");
        }
        else if (randomValue == 3)
        {
                //audioSource.PlayOneShot(soundClip3);
                soundClip3.Play();
                Debug.Log("Press D");
        }
    }
}
