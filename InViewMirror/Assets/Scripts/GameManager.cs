using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public FadeRed[] interactableObjects;

    public GameObject endingTrigger;

    void Start()
    {
       
        bool[] hasInteractedWith = new bool[interactableObjects.Length];

        for (int i = 0; i < interactableObjects.Length; i++)
        {
            hasInteractedWith[i] = false;
        }
    }

    void Update()
    {
       
        bool allInteracted = true;

        for (int i = 0; i < interactableObjects.Length; i++)
        {
            if (!interactableObjects[i].hasInteracted)
            {
                allInteracted = false;
                break;
            }
        }

        
        if (allInteracted)
        {
            Debug.Log("DONE");
            endingTrigger.SetActive(true);
        }
    }
}

