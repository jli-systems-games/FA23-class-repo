using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InspectRaycast : MonoBehaviour
{
    
    [SerializeField] private float rayLength = 1.5f;
    [SerializeField] private LayerMask WoodLogs;

    [Header("Crosshair UI")]
    public GameObject defaultCrosshair;
    public GameObject clickableCrosshair;
    
    public TextMeshProUGUI scoreText;
    private int score;

    // [Header("TreeTrunks")]
    public MakeACampfire CampfireScript;
    // public GameObject Tree1 
    // public GameObject Tree2
    // public GameObject Tree3
    // public GameObject Tree4
    // public GameObject Tree5

    
    

    // Update is called once per frame
    void Start()
    {
        score = 0;
    }
    void Update()
    {
        
        

        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        
        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, WoodLogs.value))
        {
            
            if(Input.GetMouseButtonDown(0))
            {
                score++;
                UpdateScoreText();
                
              
            }
            
            //if(score == 6)
            //{
                //CampfireScript.enabled = true;
           //}
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
        
        void UpdateScoreText()
        {
            scoreText.text = "" + score.ToString();
        }
       


            
        
    }

    

    
    
}

