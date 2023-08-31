using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public GameObject winScreen;
    public GameObject Shoot;

    public void GameOver()
    {
        winScreen.SetActive(true);
        Shoot.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
