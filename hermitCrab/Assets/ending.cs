using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending : MonoBehaviour
{
    public GameObject crabShell;
    public GameObject endingPoem;
    public GameObject instrTxt;
    void Start()
    {
        crabShell.GetComponent<Rigidbody>().isKinematic = false;
        endingPoem.SetActive(true);
        instrTxt.SetActive(false);
        
    }

    void Update()
    {
        
    }
}
