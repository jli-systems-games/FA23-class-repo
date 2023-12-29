using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{

    private void Update()
    {
        //Invoke("ResetTheScene", 2.0f);
    }
    public void ResetTheScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
