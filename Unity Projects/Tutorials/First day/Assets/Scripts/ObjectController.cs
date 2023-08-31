using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectController : MonoBehaviour
{
    public Button btn;
    public GameObject particleSpawn;
    private void OnCollisionEnter(Collision collision)
    {
        btn.interactable = true;
        
        Instantiate(particleSpawn, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
