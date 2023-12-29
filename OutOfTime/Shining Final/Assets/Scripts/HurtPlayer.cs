using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public GameObject death;
    public GameObject bullet;
    public int collisionCount = 5;

    public GameObject musicPlayer;

    public AudioClip hurt;
    public AudioClip lose;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("projectile"))
        {
            collisionCount--;
            Debug.Log("Collision count: " + collisionCount);
            audioSource.PlayOneShot(hurt);
            bullet.SetActive(false);
        }
    }

    void Update()
    {
        if (collisionCount <= 0)
        {
            Debug.Log("You Dead");
            audioSource.PlayOneShot(lose);
            death.SetActive(true);
            gameObject.SetActive(false);
            musicPlayer.SetActive(false);
        }
    }

}
