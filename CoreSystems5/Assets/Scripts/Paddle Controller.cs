using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal")*0.02f, 0f, 0f);
    }
}
