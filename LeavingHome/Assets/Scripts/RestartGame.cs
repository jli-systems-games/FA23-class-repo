using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public Animator animator;
    public GameObject music;

    public void Start()
    {
        music = GameObject.Find("Audio Source");
    }
    public void Restart()
    {
        Debug.Log("pressed");
        animator.SetTrigger("Restart");
    }

    public void Switch()
    {
        Destroy(music);
        SceneManager.LoadScene("Game");

    }
}
