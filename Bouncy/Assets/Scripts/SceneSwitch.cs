using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("Game");
    }
    public void GameRestart()
    {
        SceneManager.LoadScene("Start");
    }

}
