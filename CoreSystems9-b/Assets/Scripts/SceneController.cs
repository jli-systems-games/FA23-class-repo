using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadStart()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
