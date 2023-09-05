using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InspectRaycast : MonoBehaviour
{
    
    [SerializeField] private float rayLength = 1.5f;
    [SerializeField] private LayerMask WoodLogs;
    public MakeACampfire CampfireScript;


    [Header("Crosshair UI")]
    public GameObject defaultCrosshair;
    public GameObject clickableCrosshair;
    
    public TextMeshProUGUI scoreText;
    private int score;

    public Animator EndObjective;
   
    
    

    // Update is called once per frame
    void Start()
    {
        score = 0;
    }
    void Update()
    {
        if(scoreText.text == "6")
        {
            
            
            CampfireScript.enabled = true; 
            EndObjective.SetTrigger("ObjectiveAnim");
        }

        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        
        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, WoodLogs.value))
        {
            
            if(Input.GetMouseButtonDown(0))
            {
                
                score++;
                UpdateScoreText();
                
              
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

    void UpdateScoreText()
    {
        scoreText.text = "" + score.ToString();
    }

    

    
    
}

