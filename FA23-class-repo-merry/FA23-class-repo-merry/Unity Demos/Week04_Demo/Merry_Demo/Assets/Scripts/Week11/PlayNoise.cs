using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNoise : MonoBehaviour
{

    /*
     private AudioSource _source;  
    

    private void Start()
    {
        _source = GetComponent<AudioSource>(); 
        
    }
    void PlaySound(AudioClip clip) 
    {
        _source.clip = clip;
        _source.Play();
        
    }
    

    public void TakeStep()
    {
        _source.clip = clip;
        _source.Play();
    }
    */


    private AudioSource _source;  
    public AudioClip clip;

    private void Start()
    {
        _source = GetComponent<AudioSource>(); 
        //Player.onPlayerStep += TakeStep;
    }

    /*
    void PlaySound(AudioClip clip) //can't have arguement in event call
    {
        _source.clip = clip;
        _source.Play();
        
    }
    */

    public void TakeStep()
    {
        _source.clip = clip;
        _source.Play();
    }
}
