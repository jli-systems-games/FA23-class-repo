using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RaycastForTree3 : MonoBehaviour
{
    [SerializeField] private float rayLength = 1.5f;
    [SerializeField] private LayerMask WoodLogs;

    
    public TextMeshProUGUI scoreText;
    private int score;
    


    
    
    
    public GameObject Tree3;
    
    

    
    

    // Update is called once per frame
   
    void Update()
    {

        

        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        
        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, WoodLogs.value))
        {
            
            if(Input.GetMouseButtonDown(0))
            {
                Tree3.SetActive(false);
                //score++;
                //UpdateScoreText();
            }
        }
   
    }
    //void UpdateScoreText()
    //{
        //scoreText.text = "" + score.ToString();
    //}
}
