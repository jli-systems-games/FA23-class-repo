using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorCheck3 : MonoBehaviour
{
    public void OnTriggerEnter2D()
    {
        SceneManager.LoadScene("4");
    }
}
