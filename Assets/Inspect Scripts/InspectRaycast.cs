using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InspectRaycast : MonoBehaviour
{
    
    [SerializeField] private float rayLength = 1.5f;
    [SerializeField] private LayerMask layerMaskInteract;

    [Header("Turning Off the TV")]
    [SerializeField] private LayerMask remoteMask;
    public GameObject TVon;
    public GameObject TVoff;
    public AudioSource tvStaticSound;
    public GameObject TVLIGHT;
    public GameObject triggerForTVText;

    public AudioSource interactRemoteSound;

    [Header("Crosshair and Icons")]
    public GameObject defaultCrosshair;
    public GameObject clickablCrosshair;
    

    private bool doOnce;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        
        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, remoteMask.value))
        {
            
            if(Input.GetMouseButtonDown(0))
            {
                interactRemoteSound.Play();
                TVon.SetActive(false);
                TVoff.SetActive(true);
                TVLIGHT.SetActive(false);
                tvStaticSound.Stop();
                triggerForTVText.SetActive(false);
            }
        }

        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, layerMaskInteract.value))
        {
            
            defaultCrosshair.SetActive(true);
            //clickablCrosshair.SetActive(true);
        }
            
        else
        {
            defaultCrosshair.SetActive(false);
            //clickablCrosshair.SetActive(false);
        }
        
       


            
        
    }

    
    
}
