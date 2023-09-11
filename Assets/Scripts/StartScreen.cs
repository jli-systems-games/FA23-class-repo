using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StartScreen : MonoBehaviour
{
    public static bool gamePause=true;
    public GameObject pauseUI;
    public GameObject instructions;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (gamePause == true)
        {
            Pause();
        }
       
    }

    public void Resume()
    {
        pauseUI.SetActive(false);
        instructions.SetActive(true);
        Time.timeScale = 1f;
        gamePause = false;
    }
   

    void Pause()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        gamePause = true;
    }

        
}
