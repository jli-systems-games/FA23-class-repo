using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toLevelSelect : MonoBehaviour
{
    public void sceneSwitch()
    {
        SceneManager.LoadScene("Level Selection");
    }
}