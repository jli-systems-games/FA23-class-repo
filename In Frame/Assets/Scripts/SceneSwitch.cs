using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        if (currentScene.name == "Game")
        {
            if (InCameraDetector.bird && InCameraDetector.mushroom && InCameraDetector.flower)
            {
                StartCoroutine(Waiting());
            }
        }
        if (currentScene.name == "End")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Game");
            }
        }
    }

    IEnumerator Waiting()
    {
       
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("End");

    }
}
