using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = UnityEngine.SceneManagement.Scene;

public class SceneChange : MonoBehaviour
{
    private Scene currScene;
    public AudioSource music;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currScene = SceneManager.GetActiveScene();
            if (currScene.name == "StartScene")
            {
                SceneManager.LoadScene("Intro");
            }
            if (currScene.name == "Intro")
            {
                SceneManager.LoadScene("Game");
            }
            if (currScene.name == "EndScene")
            {
                Destroy(music);
                SceneManager.LoadScene("StartScene");
            }

        }
    }
}
