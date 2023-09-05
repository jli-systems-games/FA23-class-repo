using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StartGame : MonoBehaviour
{
    [Header("UI")]
    
    public AudioSource GameMusic;
    
    public AudioSource StartSound;
    public GameObject OakwoodBackground;
    public Animator DefaultCrosshair;
    public Animator FadeBackImage;
    public GameObject OakwoodText;
    public GameObject RestartOption;
    public GameObject Score;
    public GameObject MainCam;
    public GameObject PlayerController;

    public Animator OakwoodObjective;

    public Animator PRESSR;
    public GameObject PressSpaceToStart;

    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameMusic.Stop();
            StartSound.Play();
            
            OakwoodBackground.SetActive(false);
            FadeBackImage.SetTrigger("Fade");
            Score.SetActive(true);
            OakwoodText.SetActive(false);
            MainCam.SetActive(false);
            RestartOption.SetActive(true);
            PlayerController.SetActive(true);
            OakwoodObjective.SetTrigger("ObjectiveAnim");
            PressSpaceToStart.SetActive(false);
            DefaultCrosshair.SetTrigger("FadeCross");
            PRESSR.SetTrigger("PressR");
        }
    }

   
}
