using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorCheck2 : MonoBehaviour
{
    public GetKeyToGO keyCheck;
    public GameObject keyObj;

    public GameObject canvas;

    void Start()    
    {
        keyCheck = keyObj.GetComponent<GetKeyToGO>();
    }

    public void OnTriggerEnter2D()
    {
        if (keyCheck.keyGet)
        {
            SceneManager.LoadScene("3");
        }
        else
        {
            canvas.SetActive(true);
        }
    }

    public void OnTriggerExit2D()
    {
        canvas.SetActive(false);
    }
}
