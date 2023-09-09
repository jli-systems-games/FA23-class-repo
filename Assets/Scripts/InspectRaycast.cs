using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InspectRaycast : MonoBehaviour
{
    
    [SerializeField] private float rayLength = 2.5f;
    [SerializeField] private LayerMask PickupMask;
    

    public TMP_Text songName;
    public TMP_Text artistName;
    
   // public Outline outlineScript;
    
    

    
   
    
    

    // Update is called once per frame
    void Start()
    {

    }
    void Update()
    {
        

        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        


        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, PickupMask.value))
        {
            //outlineScript.enabled = true;
            if(hit.collider.CompareTag("snw"))
            {
            songName.text = "Saturday Night Wrist";
            artistName.text = "Deftones";
            
            }

            if(hit.collider.CompareTag("pony"))
            {
                songName.text = "White Pony";
                artistName.text = "Deftones";
            }

            if(hit.collider.CompareTag("mop"))
            {
                songName.text = "Master of Puppets";
                artistName.text = "Metallica";
            }

            if(hit.collider.CompareTag("tna"))
            {
                songName.text = "The New Abnormal";
                artistName.text = "The Strokes";
            }

            if(hit.collider.CompareTag("facelift"))
            {
                songName.text = "Facelift";
                artistName.text = "Alice in Chains";
            }

            if(hit.collider.CompareTag("fame"))
            {
                songName.text = "The Fame";
                artistName.text = "Lady Gaga";
            }

            if(hit.collider.CompareTag("btw"))
            {
                songName.text = "Jar";
                artistName.text = "Superheaven";
            }

            if(hit.collider.CompareTag("let"))
            {
                songName.text = "The Low End Theory";
                artistName.text = "A Tribe Called Quest";
            }

            if(hit.collider.CompareTag("orange"))
            {
                songName.text = "Channel Orange";
                artistName.text = "Frank Ocean";
            }

            if(hit.collider.CompareTag("hoh"))
            {
                songName.text = "Hatful of Hollow";
                artistName.text = "The Smiths";
            }

            if(hit.collider.CompareTag("letgo"))
            {
                songName.text = "Let Go";
                artistName.text = "Avril Lavigne";
            }

            if(hit.collider.CompareTag("flyleaf"))
            {
                songName.text = "Flyleaf";
                artistName.text = "Flyleaf";
            }

            if(hit.collider.CompareTag("bne"))
            {
                songName.text = "Brand New Eyes";
                artistName.text = "Paramore";
            }

            if(hit.collider.CompareTag("sp"))
            {
                songName.text = "Scott Pilgrim Vs. The World (Original Motion Picture Soundtrack)";
                artistName.text = "";
            }

            if(hit.collider.CompareTag("riot"))
            {
                songName.text = "Riot!";
                artistName.text = "Paramore";
            }

            if(hit.collider.CompareTag("awkif"))
            {
                songName.text = "All We Know is Falling";
                artistName.text = "Paramore";
            }

            if(hit.collider.CompareTag("wcpgw"))
            {
                songName.text = "What Could Possibly Go Wrong";
                artistName.text = "Dominic Fike";
            }

            if(hit.collider.CompareTag("sunburn"))
            {
                songName.text = "Sunburn";
                artistName.text = "Dominic Fike";
            }

            if(hit.collider.CompareTag("soad"))
            {
                songName.text = "System of a Down";
                artistName.text = "System of a Down";
            }

            if(hit.collider.CompareTag("loathe"))
            {
                songName.text = "I Let It in and It Took Everything";
                artistName.text = "Loathe";
            }
        }
            
        else
        {
            //outlineScript.enabled = false;
            songName.text = "";
            artistName.text = "";
            //songName.SetActive(false);

        }
        
    
    
       


            
        
    }

    
    

    

    
    
}

