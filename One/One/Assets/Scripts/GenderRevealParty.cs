using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenderRevealParty : MonoBehaviour
{
    public GameObject objectToActivate;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Camera"))
        {
            objectToActivate.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Camera"))
        {
            objectToActivate.SetActive(false);
        }
    }
}
