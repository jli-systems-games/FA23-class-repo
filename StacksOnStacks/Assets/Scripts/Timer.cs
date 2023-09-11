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

    public AudioSource victorySFX;
    public AudioSource bg;

    public GameObject endingCameraAnim;

    public TMP_Text instructionsTxt;
    public TMP_Text timerTxt;

    [SerializeField] private float _cycles = 2;

    void Start()
    {
        TimerOn = true;
    }

    void Update()
    {
        if (TimerOn)
        {
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
                instructionsTxt.DOFade(0f, duration);
                timerTxt.DOFade(0f, duration);
                victorySFX.Play();
                bg.Pause();
                TimerOn = false;
                endingCameraAnim.GetComponent<cameraEnd>().enabled = true;
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
