using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outBounds : MonoBehaviour
{
    public GameObject boundingBox;
    public GameObject pancakeSingle;
    public float timeBeforeRespawn = 1.5f;

    public AudioSource bruh;

    public float pancakeSpawnX = -2.56f;
    public float pancakeSpawnY = 1.54f;
    public float pancakeSpawnZ = -5.82f;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "pancake")
        {
            StartCoroutine(makeNewPancake());
            bruh.Play();
        }

    }

    private IEnumerator makeNewPancake()
    {
        yield return new WaitForSeconds(timeBeforeRespawn);
        Instantiate(pancakeSingle, new Vector3(pancakeSpawnX, pancakeSpawnY, pancakeSpawnZ), Quaternion.Euler(-90, 0, 0));

    }
}