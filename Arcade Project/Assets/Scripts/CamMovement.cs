using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    
    public GameObject player;


    void Update()
    {
        Vector3 position = transform.position;
        position.y = player.transform.position.y + 15f;
        transform.position = position;
    }
}
