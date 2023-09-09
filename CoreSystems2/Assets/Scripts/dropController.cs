using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropController : MonoBehaviour
{
    public Building buildScript1;
    public Building buildScript2;
    public Building buildScript3;
    public Building buildScript4;
    public Building buildScript5;

    public GameObject section1;
    public GameObject section2;
    public GameObject section3;
    public GameObject section4;
    public GameObject section5;

    void Start()
    {
        buildScript1 = section1.GetComponent<Building>();
        buildScript2 = section2.GetComponent<Building>();
        buildScript3 = section3.GetComponent<Building>();
        buildScript4 = section4.GetComponent<Building>();
        buildScript5 = section5.GetComponent<Building>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
