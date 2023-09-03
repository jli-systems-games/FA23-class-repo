using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InspectRaycast : MonoBehaviour
{
    
    [SerializeField] private float rayLength = 1.5f;
    [SerializeField] private LayerMask WoodLogs;

    public GameObject defaultCrosshair;
    public GameObject clickableCrosshair;
    
    public Text MyText;
    private int score;
    

    // Update is called once per frame
    void Start()
    {
        MyText.text = "";
    }
    void Update()
    {

        MyText.text = "$" + score;

        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        
        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, WoodLogs.value))
        {
            
            if(Input.GetMouseButtonDown(0))
            {
                score = score + 1;

            }
        }

        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, WoodLogs.value))
        {
            
            defaultCrosshair.SetActive(false);
            clickableCrosshair.SetActive(true);
        }
            
        else
        {
            defaultCrosshair.SetActive(true);
            clickableCrosshair.SetActive(false);
        }
        
       


            
        
    }

    
    
}

