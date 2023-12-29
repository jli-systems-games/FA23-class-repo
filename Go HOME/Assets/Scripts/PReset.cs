using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PReset : MonoBehaviour
{
    // You can call this function from a UI button or any other trigger
    public void ResetCurrentScene()
    {
        // Get the currently active scene's name
        string currentSceneName = SceneManager.GetActiveScene().name;

        // Reload the current scene
        SceneManager.LoadScene(currentSceneName);
    }
}
