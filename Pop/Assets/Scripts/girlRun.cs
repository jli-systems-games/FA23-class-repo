using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girlRun : MonoBehaviour
{
    public GameObject theGirl;

    private void OnTriggerEnter(Collider other)
    {
        theGirl.SetActive(true);
    }
}
