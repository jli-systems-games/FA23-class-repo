using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportAndText : MonoBehaviour
{
    public GameObject player;
    public Vector2 destination;



    void OnTriggerEnter2D()
    {
        player.transform.position = destination;
    }
}
