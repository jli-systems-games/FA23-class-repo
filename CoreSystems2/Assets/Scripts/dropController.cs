using System.Collections;
using System.Collections.Generic;
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

    public int counter = 0;
    public int otherCounter = 0;

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
                buildScript4.enabled = true;
                break;
            case 3:
                buildScript3.enabled = true;
                break;
            case 2:
                buildScript2.enabled = true;
                break;
            case 1:
                buildScript1.enabled = true;
                break;
            default:
                break;
        }

        switch (otherCounter)
        {
            case 4: 
                buildScript4.enabled = false;
                break;
            case 3: 
                buildScript3.enabled = false;
                break;
            case 2: 
                buildScript2.enabled = false;
                break;
            case 1: 
                buildScript1.enabled = false;
                break;
            default:
                break;
        }
    }
}