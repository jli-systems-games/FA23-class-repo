using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    public ScoreManager scoreManager;

    public GameObject pancakeSingle;
    public float pancakeSpawnX = -2.56f;
    public float pancakeSpawnY = 1.54f;
    public float pancakeSpawnZ = -5.82f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pancake")) 
        {
            scoreManager.AddPoints(1);
            Instantiate(pancakeSingle, new Vector3(pancakeSpawnX, pancakeSpawnY, pancakeSpawnZ), Quaternion.Euler(-90, 0, 0));
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
