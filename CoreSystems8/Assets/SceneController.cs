using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toEnd()
    {
        SceneManager.LoadScene("end Scene");
    }

    public void toGame()
    {
        SceneManager.LoadScene("game Scene");
    }

    public void endGame()
    {
        Application.Quit();
    }

}
