using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarCollision : MonoBehaviour
{
    public AudioSource starSound;
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            starSound.Play();  
            Debug.Log("Hit!");
            Destroy(gameObject);
            Points.points++;
            Debug.Log(Points.points);
        }

        if (Points.points == 5)
        {
            Debug.Log("WIN!");
            SceneManager.LoadScene("EndScene");
        }


    }
}
