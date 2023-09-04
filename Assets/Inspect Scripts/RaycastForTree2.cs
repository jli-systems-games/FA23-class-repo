using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RaycastForTree2 : MonoBehaviour
{
    [SerializeField] private float rayLength = 1.5f;
    [SerializeField] private LayerMask WoodLogs;

    public TextMeshProUGUI scoreText;
    private int score;
    
    

    // [Header("TreeTrunks")]
    
    //public GameObject Tree1; 
    public GameObject Tree2;
    // public GameObject Tree3
    // public GameObject Tree4
    // public GameObject Tree5

    
    

    // Update is called once per frame
   
    void Update()
    {

        

        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        
        if(Physics.Raycast(transform.position, fwd, out hit, rayLength))
        {
            
            if(Input.GetMouseButtonDown(0))
            {
                //score ++;
                //UpdateScoreText();
                Tree2.SetActive(false);
                
              
            }
        }
   
    }
    //void UpdateScoreText()
    //{
        //scoreText.text = "" + score.ToString();
    //}
}
