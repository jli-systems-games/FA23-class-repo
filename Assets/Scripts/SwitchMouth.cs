using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMouth : MonoBehaviour
{
    public GameObject mouth;

    public int mouthNum = 0;

    public Sprite[] mouthArray;

    public SpriteRenderer mouthRenderer;
    public void Start()
    {
        mouthRenderer = mouth.GetComponent<SpriteRenderer>();

    }
    public void PlusClick()
    {
        if (mouthNum == mouthArray.Length - 1)
        {
            mouthNum = 0;
        }
        else
        {
            mouthNum++;
        }
        mouthRenderer.sprite = mouthArray[mouthNum];
    }
    public void MinusClick()
    {
        if (mouthNum == 0)
        {
            mouthNum = mouthArray.Length - 1;
        }
        else
        {
            mouthNum--;
        }
        mouthRenderer.sprite = mouthArray[mouthNum];
    }
}
