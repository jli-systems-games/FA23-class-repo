using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toInGame : MonoBehaviour
{
    public void switchToDropTubes()
    {
        SceneManager.LoadScene("DropTubes");
    }
}
