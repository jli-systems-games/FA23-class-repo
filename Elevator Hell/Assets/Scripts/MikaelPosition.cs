using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class MikaelPosition : MonoBehaviour
{
    public GameObject mikael;

    [YarnCommand("move_mikael")]
    public void MoveMikael(int x, int flip)
    {
        mikael.transform.position = new Vector3(transform.position.x + x, transform.position.y, transform.position.z);

        Vector3 newRotation = new Vector3(transform.rotation.x, flip, transform.rotation.z);
        mikael.transform.eulerAngles = newRotation;

    }
}
