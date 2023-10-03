using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void toHome()
    {
        SceneManager.LoadScene("Home");
    }
    public void toGame()
    {
        SceneManager.LoadScene("Game");
    }
}
