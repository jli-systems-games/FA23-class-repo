using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsManager : MonoBehaviour
{
    public static int points;
    public TextMeshProUGUI numberHolder;

    public void PointsIncreaseBy25()
    {
        points+=5;
        numberHolder.text = points.ToString();
    }

    public void PointsIncreaseBy10()
    {
        points+=10;
        numberHolder.text = points.ToString();
    }
}
