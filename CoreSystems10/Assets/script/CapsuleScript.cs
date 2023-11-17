using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CapsuleScript : MonoBehaviour
{
    public GameObject KeyObj;
    public GetKeyToGO KeyScript;
    public GameObject canvas;
    public GameObject trigger;

    //public string[] txtArray;
    public TextMeshProUGUI text;
    //public int index = 0;

    void Start()
    {
        KeyScript = KeyObj.GetComponent<GetKeyToGO>();   
    }

    public void OnTriggerEnter2D()
    {
        if(KeyScript.keyGet)
        {
            text.text = "...You may go.";
            canvas.SetActive(true);
            trigger.SetActive(true);
        }
        
        else 
        {
            text.text = "I'm a default Unity capsule";
            canvas.SetActive(true);
        }
    }

    public void OnTriggerExit2D()
    {
        canvas.SetActive(false);
    }
}
