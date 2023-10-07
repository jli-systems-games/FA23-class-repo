using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {

            ReloadScene();
        }
    }


    void ReloadScene()
    {
        Cursor.lockState = CursorLockMode.None;
        string currentSceneName = SceneManager.GetActiveScene().name;


        SceneManager.LoadScene(currentSceneName);
    }
}
