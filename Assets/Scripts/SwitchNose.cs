using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchNose : MonoBehaviour
{
    public GameObject nose;

    public int noseNum = 0;

    public Sprite[] noseArray;
    
    public SpriteRenderer noseRenderer;
    public void Start()
    {
        noseRenderer = nose.GetComponent<SpriteRenderer>();
        
    }
    public void PlusClick()
    {
        if (noseNum == noseArray.Length - 1)
        {
            noseNum = 0;
        }
        else
        {
            noseNum++;
        }
        noseRenderer.sprite = noseArray[noseNum];
    }
    public void MinusClick()
    {
        if (noseNum == 0)
        {
            noseNum = noseArray.Length - 1;
        }
        else
        {
            noseNum--;
        }
        noseRenderer.sprite = noseArray[noseNum];
    }
}
