using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject booletsPrefab;
    public Camera playerCamera;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletObject = Instantiate(booletsPrefab);
            bulletObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward;

        }
    }
}

