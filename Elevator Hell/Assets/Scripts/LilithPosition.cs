using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class LilithPosition : MonoBehaviour
{
    public GameObject lilith;

    [YarnCommand("move_lilith")]
    public void MoveLilith(int x, int flip) {
        lilith.transform.position = new Vector3(transform.position.x+ x, transform.position.y, transform.position.z);
     
        Vector3 newRotation = new Vector3(transform.rotation.x, flip, transform.rotation.z);
        lilith.transform.eulerAngles = newRotation;

    }
}
