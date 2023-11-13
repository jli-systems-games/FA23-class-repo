using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyToGO : MonoBehaviour
{
    public bool keyGet = false;
    public void OnTriggerEnter2D()
    {
        keyGet = true;
    }
}
