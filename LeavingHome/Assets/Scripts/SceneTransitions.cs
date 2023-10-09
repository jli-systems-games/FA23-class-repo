using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class SceneTransitions : MonoBehaviour
{
    public Animator animator;

    [YarnCommand("start_fade")]
    public void StartFade()
    {

        animator.SetTrigger("StartScene");
    }

    [YarnCommand("ending_fade")]

    public void EndFade()
    {
        animator.SetTrigger("GameEnd");

    }

    public void EndScene()
    {
        SceneManager.LoadScene("End");
    }

}
