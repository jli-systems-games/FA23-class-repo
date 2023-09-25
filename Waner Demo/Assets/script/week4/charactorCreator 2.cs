using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class charactorCreator : MonoBehaviour
{
    //UI referenced
    public int pointsRemaining;
    public TextMeshProUGUI pointsRemaingTMP;
    // Start is called before the first frame update
    void Start()
    {
        pointsRemaingTMP.text = pointsRemaining.ToString();
    }

    public void AdjustPoints(int point)
    {
        pointsRemaining -= point;
        pointsRemaingTMP.text = pointsRemaining.ToString();
    }
}
