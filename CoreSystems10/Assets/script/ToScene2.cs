using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToScene2 : MonoBehaviour
{
    public void OnTriggerEnter2D()
    {
        SceneManager.LoadScene("2");
    }
    
}
