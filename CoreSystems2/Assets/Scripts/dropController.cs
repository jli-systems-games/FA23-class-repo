using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class dropController : MonoBehaviour
{
    public Building buildScript1;
    public Building buildScript2;
    public Building buildScript3;
    public Building buildScript4;

    public GameObject section1;
    public GameObject section2;
    public GameObject section3;
    public GameObject section4;

    public GameObject perfectsection1;
    public GameObject perfectsection2;
    public GameObject perfectsection3;
    public GameObject perfectsection4;

    public GameObject completeScreen;

    public int counter = 0;
    public int otherCounter = 0;
    public float sec1diff;
    public float sec2diff;
    public float sec3diff;
    public float sec4diff;
    public float points;


    public Vector3 theVector = new Vector3 (0,0,0);

    public bool going = false;


    void Start()
    {
        buildScript1 = section1.GetComponent<Building>();
        buildScript2 = section2.GetComponent<Building>();
        buildScript3 = section3.GetComponent<Building>();
        buildScript4 = section4.GetComponent<Building>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (going)
            {
                otherCounter++;
                going = false;
                Debug.Log("stop "+ otherCounter);
            }

            else
            {
                counter++;
                going = true;
                Debug.Log("go " + counter);
                
            }
            
        }

        switch (counter)
        {
            case 4:
                buildScript4.startGoing();
                break;
            case 3:
                buildScript3.startGoing();
                break;
            case 2:
                buildScript2.startGoing();
                break;
            case 1:
                buildScript1.startGoing();
                break;
            default:
                break;
        }

        switch (otherCounter)
        {
            case 4: 
                section4.GetComponent<Rigidbody>().velocity = theVector;
                section4.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX| RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
                calculateDifference4();
                break;
            case 3: 
                section3.GetComponent<Rigidbody>().velocity = theVector;
                section3.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
                calculateDifference3();
                break;
            case 2: 
                section2.GetComponent<Rigidbody>().velocity = theVector;
                section2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
                calculateDifference2();
                break;
            case 1: 
                section1.GetComponent<Rigidbody>().velocity = theVector;
                section1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX |RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
                calculateDifference1();
                break;
            default:
                break;
        }
        
        
    }

    public void calculateDifference1()
    {
        sec1diff = perfectsection1.transform.position.x - section1.transform.position.x;
    }

    public void calculateDifference2()
    {
        sec2diff = perfectsection1.transform.position.x - section1.transform.position.x;
    }

    public void calculateDifference3()
    {
        sec3diff = perfectsection1.transform.position.x - section1.transform.position.x;
    }

    public void calculateDifference4()
    {
        sec4diff = perfectsection1.transform.position.x - section1.transform.position.x;
    }
}