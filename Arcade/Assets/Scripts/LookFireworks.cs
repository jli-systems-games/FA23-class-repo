using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookFireworks : MonoBehaviour
{

    public ParticleSystem fireworks;
    public GameObject fireworksCam;
    public AudioSource fireworksSFX;

    public float waitFireworks = 40f;

    public GameObject badGuy;

    private void OnTriggerEnter(Collider other)
    {
        fireworks.Play();
        fireworksSFX.Play();
        fireworksCam.SetActive(true);
        badGuy.SetActive(true);
        StartCoroutine(waitforFireworks());
    }

    IEnumerator waitforFireworks()
    {
        yield return new WaitForSeconds(waitFireworks);
        fireworks.Pause();
    }

}
