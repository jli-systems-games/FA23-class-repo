using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kinger : MonoBehaviour
{
    public GameObject objectToDeactivate;
    public GameObject objectToInstantiate;
    public GameObject objectToActivate;
    public float delay = 0.1f;
    public float superdelay = 0.5f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            objectToDeactivate.SetActive(false);
            Invoke("InstantiateObject", delay);
            Invoke("DeathScreen", superdelay);
        }
    }

    private void InstantiateObject()
    {
        Instantiate(objectToInstantiate, transform.position, Quaternion.identity);
    }

    private void DeathScreen()
    {
        objectToActivate.SetActive(true);
    }
}
