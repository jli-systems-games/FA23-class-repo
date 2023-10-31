using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (SceneManager.GetActiveScene().name == "EndScreen")
            {
                Destroy(GameObject.Find("Timer"));
                SceneManager.LoadScene("Start");
            }
            if (SceneManager.GetActiveScene().name == "Start")
            {
                SceneManager.LoadScene("Game");
            }
        }
    }
}
