using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class gameManager : MonoBehaviour
{   
    public static int score = 0;
    public static int currentScore = 0;

    public TMP_Text scoreTMP;

    public static Action<int> ScoreIncreased;

    void Start()
    {
        ScoreIncreased += IncreaseScore;
        ScoreIncreased += DoThis;
    }

    public void IncreaseScore(int x)
    {
        score++;
        scoreTMP.text = score.ToString();
    }

    public void DoThis(int y)
    {
        
    }
}
