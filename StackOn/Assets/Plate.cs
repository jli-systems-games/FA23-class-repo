using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    public ScoreManager scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pancake")) 
        {
            scoreManager.AddPoints(1); 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("pancake")) 
        {
            scoreManager.SubtractPoints(1); 
        }
    }
}
