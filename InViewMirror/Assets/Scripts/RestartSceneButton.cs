using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartSceneButton : MonoBehaviour
{

    public Button restartButton;

    private void Start()
    {

        restartButton.onClick.AddListener(RestartScene);
    }

    public void RestartScene()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}

