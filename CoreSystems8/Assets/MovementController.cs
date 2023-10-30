using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public Animator anim;

    public bool isIdle;
    public bool isJumping;
    public bool isWalkign;

    void Start()
    {
        
    }

    void Update()
    {
        
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
            {
                anim.SetBool("isWalkign", true); 
            }
            else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
            {
                anim.SetBool("isWalkign", false);
            }

            else if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("isJumping", true);
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                anim.SetBool("isJumping", false);
            }
        
    }
}
