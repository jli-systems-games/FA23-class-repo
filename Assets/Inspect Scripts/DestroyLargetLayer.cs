using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LayerComparisonAndDestroy : MonoBehaviour
{

    public LayerMask WoodLogs; 

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, WoodLogs))
            {
                GameObject hitObject = hit.collider.gameObject;
                Destroy(hitObject);
            }
        }
    }
}
