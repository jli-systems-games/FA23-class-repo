using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject particleSpawn;
    //public GameManager manager;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet") //lowercase "game" because it is the object of the collision
        {
            Instantiate(particleSpawn, transform.position, Quaternion.identity);
            //manager.GameOver();
            Destroy(gameObject);
        }
    }
}
