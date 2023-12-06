using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class BGMusic : MonoBehaviour
{
    public static BGMusic instance;
 
    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        if (currentScene.name == "Childhood" || currentScene.name == "Middle" || currentScene.name == "College")
        {
            // Stops playing music in level 1 scene
            Destroy(gameObject);
        }
    }
}