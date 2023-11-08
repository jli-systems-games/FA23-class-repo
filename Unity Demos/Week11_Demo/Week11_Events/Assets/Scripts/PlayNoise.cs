using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNoise : MonoBehaviour
{
    private AudioSource _source;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        _source = GetComponent<AudioSource>();
        Player.onPlayerStep += PlaySound;
        Player.onPlayerTakeDamage += TakeDamage;

    }
    public void PlaySound()
    {
        _source.clip = clip;
        _source.Play();
    }

    public void TakeDamage(int damage)
    {
        //ow
        Debug.Log("Ow " + damage);
    }

}
