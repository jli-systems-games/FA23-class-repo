using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RaycastForLog1 : MonoBehaviour
{
    [SerializeField] private float rayLength = 1.5f;
    [SerializeField] private LayerMask WoodLogs;

    public TextMeshProUGUI scoreText;
    private int score;
    
    

    // [Header("TreeTrunks")]
    
    public GameObject Tree1; 
    // public GameObject Tree2
    // public GameObject Tree3
    // public GameObject Tree4
    // public GameObject Tree5
    public AudioSource Pickup;
    
    

    // Update is called once per frame
   
    void Update()
    {

        

        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        
        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, WoodLogs.value))
        {
            
            if(Input.GetMouseButtonDown(0))
            {
                Tree1.SetActive(false);
                Pickup.Play();
                score ++;
                UpdateScoreText();
              
            }
        }
   
    }
    void UpdateScoreText()
    {
        scoreText.text = "" + score.ToString();
    }

    
    

}
