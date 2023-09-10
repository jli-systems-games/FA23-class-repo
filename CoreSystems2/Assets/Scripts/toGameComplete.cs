using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toGameComplete : MonoBehaviour
{
    public void switchToGameComplete()
    {
        SceneManager.LoadScene("GameComplete");
    }
}
