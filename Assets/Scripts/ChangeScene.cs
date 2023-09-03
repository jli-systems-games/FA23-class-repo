using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using Scene = UnityEngine.SceneManagement.Scene;

public class ChangeScene : MonoBehaviour
{
    Scene currentScene;
    public string sceneName;
    ScrollingText scrollingText;

    public void SceneChange()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        if (sceneName == "StartScene")
        {
            SceneManager.LoadScene("IntroScene");
        }
       if (sceneName == "IntroScene")
        {
            GameObject textbox = GameObject.Find("Canvas");
            scrollingText = textbox.GetComponent<ScrollingText>();
            if (scrollingText.textDone ==true)
            {
                SceneManager.LoadScene("GameScene");
            }
            
        }
    }
}
