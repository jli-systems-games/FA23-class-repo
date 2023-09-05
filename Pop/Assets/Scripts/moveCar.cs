using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCar : MonoBehaviour
{
    Rigidbody rig;
    float magnitude = 2.8f;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.AddForce(Vector3.back*magnitude, ForceMode.Impulse);
    }
}
