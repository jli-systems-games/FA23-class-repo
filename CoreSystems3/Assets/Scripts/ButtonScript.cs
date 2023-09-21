using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void endGame()
    {
        Application.Quit();
    }

    public void reloadGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
