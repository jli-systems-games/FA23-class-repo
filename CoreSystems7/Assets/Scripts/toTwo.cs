using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toTwo : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        SceneManager.LoadScene("two");
    }
}
