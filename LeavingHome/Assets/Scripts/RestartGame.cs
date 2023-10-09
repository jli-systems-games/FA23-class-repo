using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public Animator animator;
    public void Restart()
    {
        Debug.Log("pressed");
        animator.SetTrigger("Restart");
    }

    public void Switch()
    {
        SceneManager.LoadScene("Game");
    }
}
