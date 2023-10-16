using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toOne : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        SceneManager.LoadScene("one", LoadSceneMode.Single);
    }
}
