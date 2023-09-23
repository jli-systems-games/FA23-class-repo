using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class SceneChanger : MonoBehaviour
{
    public GameObject[] backgrounds;
    public Animator animator;
    public int bgToLoad;
   
    public void Start()
    {
        backgrounds[0].GetComponent<Canvas>().enabled = true;

        for (int i = 1; i < backgrounds.Length; i++) {

            backgrounds[i].GetComponent<Canvas>().enabled = false;
        }

    }

    /*public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            bgToLoad++;
            ChangeScene(bgToLoad);
        }
    }*/
    [YarnCommand("change_bg")]
    public void ChangeScene()
    {
        bgToLoad++;
        
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        if (bgToLoad <= 3)
        {
            backgrounds[bgToLoad - 1].GetComponent<Canvas>().enabled = false;
            backgrounds[bgToLoad].GetComponent<Canvas>().enabled = true;
            animator.SetTrigger("FadeIn");
        }
    }
}
