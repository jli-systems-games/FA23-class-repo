using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Windows;


public class CamMovement : MonoBehaviour
{
    public TextMeshProUGUI score;
    public int currentCount;

    public GameObject spawner;

    void Start()
    {
        currentCount = 0;
        GameObject textbox = GameObject.Find("Score");
        score = textbox.GetComponent<TextMeshProUGUI>();

    }


    void Update()
    {
        var currentScore=int.Parse(score.text); 

        if (currentCount < currentScore)
        {
            Camera.main.transform.Translate(0, 2.5f, 0);
            spawner.transform.Translate(0, 2.5f, 0);
            currentCount = currentScore;

        }

    }
}