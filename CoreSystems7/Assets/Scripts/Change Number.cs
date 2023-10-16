using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeNumber : MonoBehaviour
{
    public string[] nameSet;

    private string largest;
    private string sceneName;

    static public int whichScene;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        int whichScene = 0;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (sceneName == "one")
        {
            largest = nameSet[whichScene + 1];
            whichScene++;
            Debug.Log(largest);
            SceneManager.LoadScene(largest);
            
        }
    }
}
