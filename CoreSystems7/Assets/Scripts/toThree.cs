using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toThree : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        SceneManager.LoadScene("three");
    }
}
