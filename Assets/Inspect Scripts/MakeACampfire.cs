using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeACampfire : MonoBehaviour
{
    [SerializeField] private float rayLength = 1.5f;
    [SerializeField] private LayerMask WoodInt;

    [Header("Crosshair UI")]
    public GameObject defaultCrosshair;
    public GameObject clickableCrosshair;
    
  

    // [Header("TreeTrunks")]
    
    // public GameObject Tree1 
    // public GameObject Tree2
    // public GameObject Tree3
    public GameObject FireParticle;
    public AudioSource FireSound;
    public GameObject Campfire;
    
    
    

    // Update is called once per frame
   
    void Update()
    {
        
        

        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        
        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, WoodInt.value))
        {
            
            if(Input.GetMouseButtonDown(0))
            {
                Campfire.SetActive(true);
                StartCoroutine(StartCampfire());
                
              
            }
        }

        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, WoodInt.value))
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
    public IEnumerator StartCampfire()
    {
        yield return new WaitForSeconds(4);
        FireSound.Play();
        FireParticle.SetActive(true);

    }
}
