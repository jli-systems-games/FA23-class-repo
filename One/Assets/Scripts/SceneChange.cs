using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public static bool textDone;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if(SceneManager.GetActiveScene().name == "Start")
            {
                SceneManager.LoadScene("Intro");
            }
            if (textDone == true)
            {
                if (SceneManager.GetActiveScene().name == "Intro")
                {
                    SceneManager.LoadScene("Game");
                }
                if (SceneManager.GetActiveScene().name == "Win" || SceneManager.GetActiveScene().name == "Lose")
                {
                    SceneManager.LoadScene("Start");
                }
            }
        }
    }
}
