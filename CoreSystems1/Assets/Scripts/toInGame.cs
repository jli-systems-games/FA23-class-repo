using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toInGame : MonoBehaviour
{
    public GameObject scriptHolder;
    private difficultySelection diffSelectScript;

    void Start()
    {
        diffSelectScript = scriptHolder.GetComponent<difficultySelection>();
    }

    public void anotherSceneSwitch()
    {
        if (diffSelectScript.difficulty == "easy")
        {
            SceneManager.LoadScene("Taxi Easy Mode");
        }
        if (diffSelectScript.difficulty == "hard")
        {
            SceneManager.LoadScene("Taxi Hard Mode");
        }
    }
    //SceneManager.LoadScene("Taxi Hard Mode");
}
