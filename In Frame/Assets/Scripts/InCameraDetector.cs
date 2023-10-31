using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InCameraDetector : MonoBehaviour
{
    public Camera cam;
    public MeshRenderer rend;
    public Plane[] camFrustum;
    public Bounds bounds;
    public String tagItem;
    public AudioSource success;
    public static bool bird;
    public static bool mushroom;
    public static bool flower;

    public void Start()
    {
        cam = Camera.main;
        rend = GetComponent<MeshRenderer>();
        bounds = GetComponent<Collider>().bounds;
        success = GameObject.FindGameObjectWithTag("Success").GetComponent<AudioSource>();
        bird = false;
        mushroom = false;
        flower = false;
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CameraClick();

        }
    }
    public void CameraClick()
    {
        camFrustum = GeometryUtility.CalculateFrustumPlanes(cam);
        if(GeometryUtility.TestPlanesAABB(camFrustum, bounds))
        {
            Debug.Log(gameObject.tag);
            tagItem=gameObject.tag;

            var distance= Vector3.Distance(gameObject.transform.position, cam.transform.position);
            Debug.Log(distance);
            if (tagItem == "Bird"&& bird==false && distance<=8f)
            {
                success.Play();
                bird = true;
            }
            if (tagItem == "Mushroom" && mushroom == false && distance <= 8f)
            {
                success.Play();
                mushroom = true;
            }
            if (tagItem == "Flower" && flower == false && distance <= 8f)
            {
                success.Play();
                flower = true;
            }
        }
    }

}
