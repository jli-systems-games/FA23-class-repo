using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreTMP;

    //Buildings
    public Building[] buildingTypes;

    //Static variables
    public static int score = 0;

    //Events
    public static Action<int> ScoreIncreased;

    private void Start()
    {
        //Score Increased todo list
        ScoreIncreased += IncreaseScore;
        ScoreIncreased += DoThis;
    }
    public void IncreaseScore(int x)
    {
        score += x;
        scoreTMP.text = score.ToString();
    }

    public void DoThis(int y)
    {
        CheckValue();
    }

    private void CheckValue()
    {
        foreach (Building building in buildingTypes)
        {
            if (score >= building.cost)
                building.CanBuyBuilding(true);
            else
                building.CanBuyBuilding(false);
        }
    }
}
