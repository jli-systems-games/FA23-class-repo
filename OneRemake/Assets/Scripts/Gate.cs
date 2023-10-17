using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public GameObject playerOne;
    public GameObject playerTwo;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerTwo.SetActive(true);
            playerOne.SetActive(false);
        }
    }
}
