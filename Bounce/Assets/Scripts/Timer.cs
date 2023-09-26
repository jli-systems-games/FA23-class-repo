using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class Timer : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;

    public TMP_Text TimerText;

    public TMP_Text timerTxt;

    public GameObject restartButton;
    public TMP_Text restartTxt;

    public TMP_Text playerTwoWin;

    void Start()
    {
        TimerOn = true;
    }

    void Update()
    {
        if (TimerOn)
        {

            timerTxt.DOFade(1f, 1f).SetEase(Ease.InOutSine);
            TimerText.DOFade(1f, 1f).SetEase(Ease.InOutSine);

            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);

            }
            else
            {
                float duration = 1f;
                Debug.Log("Time is UP!");
                TimeLeft = 0;
                timerTxt.DOFade(0f, duration).SetEase(Ease.InOutSine);
                TimerText.DOFade(0f, duration).SetEase(Ease.InOutSine);
                playerTwoWin.DOFade(1f, 3f).SetEase(Ease.InOutSine);
                restartTxt.DOFade(1f, 5f).SetEase(Ease.InOutSine);
                restartButton.SetActive(true);
                TimerOn = false;
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}

