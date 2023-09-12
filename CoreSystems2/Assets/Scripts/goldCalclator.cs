using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class goldCalclator : MonoBehaviour
{
    public dropController otherScript;
    public GameObject controllerObj;

    public float max = 10f;

    public float value1;
    public float value2;
    public float value3;
    public float value4;

    public int totalgold;


    void Start()
    {
        otherScript = controllerObj.GetComponent<dropController>();
    }

    public void calculateGold()
    {
        value1 = max - (otherScript.sec1diff)*10;
        value2 = max - (otherScript.sec2diff)*10;
        value3 = max - (otherScript.sec3diff)*10;
        value4 = max - (otherScript.sec4diff)*10;

        totalgold = (int)value1 + (int)value2 + (int)value3 + (int)value4;
        Debug.Log(value1);
        Debug.Log(value2);
        Debug.Log(value3);
        Debug.Log(value4);
        Debug.Log(totalgold);
    }
}
