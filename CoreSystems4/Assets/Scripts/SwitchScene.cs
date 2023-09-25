using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void toWebsite()
    {
        SceneManager.LoadScene("Website");
    }
    public void toEmail()
    {
        SceneManager.LoadScene("Email");
    }
    public void toIllustrator()
    {
        SceneManager.LoadScene("Illustrator");
    }
    public void toZoom()
    {
        SceneManager.LoadScene("Zoom");
    }
    public void toHomeScreen()
    {
        SceneManager.LoadScene("Home Screen");
    }
    public void toEndScene()
    {
        SceneManager.LoadScene("End Screen");
    }
}

