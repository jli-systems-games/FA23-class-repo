using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class TimerHard : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;

    public TMP_Text TimerText;

    public AudioSource victorySFX;
    public AudioSource bg;
    public AudioSource ding;

    public GameObject endingCameraAnim;

    public TMP_Text instructionsTxt;
    public TMP_Text timerTxt;
    public TMP_Text scoreTxt;

    public GameObject restartButton;
    public TMP_Text restartTxt;

    public GameObject spatulaEnd;

    [SerializeField] private float _cycles = 2;

    void Start()
    {
        TimerOn = true;
    }

    void Update()
    {
        if (TimerOn)
        {
            float durationF = 1f;
            instructionsTxt.DOFade(1f, durationF);
            timerTxt.DOFade(1f, durationF);
            scoreTxt.DOFade(1f, durationF);

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
                ding.Play();
                instructionsTxt.DOFade(0f, duration);
                timerTxt.DOFade(0f, duration);
                restartTxt.DOFade(1f, duration);
                restartButton.SetActive(true);
                victorySFX.Play();
                bg.Pause();
                TimerOn = false;
                endingCameraAnim.GetComponent<cameraEnd>().enabled = true;
                spatulaEnd.GetComponent<PancakeSpatula>().enabled = false;
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

