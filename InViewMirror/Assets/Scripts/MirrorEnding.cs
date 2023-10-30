using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorEnding : MonoBehaviour
{
    public GameObject mirrorWhole;
    public ArrayList[] mirrorPieces;
    

    private void OnTriggerEnter(Collider other)
    {
        startEnding();
    }

    void startEnding()
    {
        mirrorWhole.SetActive(false);
        
    }
}
