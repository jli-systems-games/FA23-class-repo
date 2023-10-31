using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakingPhoto : MonoBehaviour
{
    public Animator flash;
    public AudioSource sound;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            flash.SetTrigger("Photo");
            sound.Play();
           
        }
        
    }
}
