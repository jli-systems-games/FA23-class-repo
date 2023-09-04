using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects2 : MonoBehaviour
{
     public LayerMask WoodLogs; 
    public float raycastDistance = 1.5f; 

    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse click
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit[] hits = Physics.RaycastAll(ray, raycastDistance, WoodLogs);

            if (hits.Length > 0)
            {
                // Destroy the first object hit by the raycast
                Destroy(hits[0].collider.gameObject);
            }
        }
    
    }
}
