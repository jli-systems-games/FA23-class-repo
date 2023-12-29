using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour
{
    [SerializeField] private CanvasGroup myUIGroup;
    [SerializeField] private bool fadeOut=false;
    public GameObject textControl;
    ScrollingText scrollingText;
    
    public void Update()
    {
        textControl = GameObject.Find("Words");
        scrollingText = textControl.GetComponent<ScrollingText>();

        if (scrollingText.textDone == true)
        {
            StartCoroutine(Fade());
            
        }
        if (fadeOut == true)
        {
            if (myUIGroup.alpha < 1)
            {
                myUIGroup.alpha += Time.deltaTime;
                if (myUIGroup.alpha >= 1)
                {
                    fadeOut = false;
                }
            }
        }


    }
    IEnumerator Fade()
    {
        yield return new WaitForSeconds(3);
        fadeOut = true;
    }

    
}
