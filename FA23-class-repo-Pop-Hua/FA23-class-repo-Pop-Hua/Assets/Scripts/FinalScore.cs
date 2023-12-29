using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static PointsManager;

public class FinalScore : MonoBehaviour
{
    public TextMeshProUGUI finalscore;

    void Update()
    {
        finalscore.text = currentScore.ToString();
    }
}
