using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldCalclator : MonoBehaviour
{
    public dropController otherScript;
    public GameObject controllerObj;

    public float max = 5f;

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
        value1 = max - otherScript.sec1diff;
        value2 = max - otherScript.sec2diff;
        value3 = max - otherScript.sec3diff;
        value4 = max - otherScript.sec4diff;

        totalgold = (int)value1 + (int)value2 + (int)value3 + (int)value4;
        Debug.Log(totalgold);
    }
}
