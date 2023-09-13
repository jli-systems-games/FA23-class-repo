using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchEyes : MonoBehaviour
{
    public GameObject leftEye;
    public GameObject rightEye;

    public int eyeNum=0;

    public Sprite[] leftEyeArray;
    public Sprite[] rightEyeArray;



    public SpriteRenderer leftRenderer;
    public SpriteRenderer rightRenderer;

    public void Start()
    {
        leftRenderer = leftEye.GetComponent<SpriteRenderer>();
        rightRenderer = rightEye.GetComponent<SpriteRenderer>();
    }
    public void PlusClick()
    {
        if (eyeNum == leftEyeArray.Length-1)
        {
            eyeNum = 0;
        }
        else
        {
            eyeNum++;
        }
        leftRenderer.sprite = leftEyeArray[eyeNum];
        rightRenderer.sprite = rightEyeArray[eyeNum];
    }
    public void MinusClick()
    {
        if (eyeNum == 0)
        {
            eyeNum = leftEyeArray.Length - 1;
        }
        else
        {
            eyeNum--;
        }
        leftRenderer.sprite = leftEyeArray[eyeNum];
        rightRenderer.sprite = rightEyeArray[eyeNum];
    }
}
