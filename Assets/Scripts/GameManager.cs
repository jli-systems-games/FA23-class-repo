using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winScreen;
    public GameObject shootButton;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            // R key is pressed, restart the current scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void GameOver()
    {
        winScreen.SetActive(true);
        shootButton.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
