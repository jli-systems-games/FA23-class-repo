using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFadeIn : MonoBehaviour
{
    public Animator button;

    // Update is called once per frame
    void Update()
    {
        if (ScrollingText.textDone)
        {
            button.SetTrigger("TextFinished");
        }
    }
}
