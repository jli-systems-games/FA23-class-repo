using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextScroll : MonoBehaviour
{
    public GameObject purpleBg;
    public GameObject greenBg;

    public GameObject canvas;

    public TMP_Text textBox; 

    public string[] textBank;

    public bool speaker = false;
    public int counter = 0;


    public void OnClick()
    {
        //Debug.Log(speaker);

        if(speaker)
        {
            greenBg.SetActive(true);
            purpleBg.SetActive(false);
            speaker = !speaker;
        }

        else
        {
            purpleBg.SetActive(true);
            greenBg.SetActive(false);
            speaker = !speaker;
        }
        
        counter++;
        textBox.text = textBank[counter];

    }

    void Update()
    {
        if (counter == 9)
        {
            canvas.SetActive(false);
        }
    }
}
